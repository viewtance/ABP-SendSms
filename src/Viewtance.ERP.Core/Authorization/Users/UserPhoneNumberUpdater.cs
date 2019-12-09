using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Events.Bus.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Sms.V20190711.Models;
using TencentCloud.Sms.V20190711;
using Castle.Core.Logging;

namespace Viewtance.ERP.Authorization.Users
{
    public class UserPhoneNumberUpdater : IAsyncEventHandler<UserUpdatedEventData>, ITransientDependency
    {
        private readonly UserManager _userManager;
        public ILogger Logger { get; set; }


        // 短信应用SDK AppID
        string appid = "1400134967";

        // 短信应用SDK AppKey
        string appkey = "6a05d41fe5c3c0ae02e08f51df2b71c1";

        // 需要发送短信的手机号码
        string[] phoneNumbers;

        // 短信模板ID，需要在短信应用中申请
        string templateId = "186294";

        // 签名
        string smsSign = "江南艺考"; // NOTE: 这里的签名只是示例，请使用真实的已申请的签名, 签名参数使用的是`签名内容`，而不是`签名ID`


        public UserPhoneNumberUpdater(
            UserManager userManager
            )
        {
            _userManager = userManager;

            Logger = NullLogger.Instance;
        }

        [UnitOfWork]
        public virtual async Task HandleEventAsync(UserUpdatedEventData eventData)
        {
            var user = await _userManager.GetUserByIdAsync(eventData.UserId);
            user.Surname = eventData.PhoneNumber;
            await _userManager.UpdateAsync(user);
            await _userManager.ChangePhoneNumberAsync(user, eventData.PhoneNumber, string.Empty);

            try
            {
                Credential cred = new Credential
                {
                    SecretId = "AKID1sZ03uwxf9Ub",
                    SecretKey = "JEyWwAA0bxBE4jAML"
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("sms.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                SmsClient client = new SmsClient(cred, "ap-shanghai", clientProfile);
                SendSmsRequest req = new SendSmsRequest();
                string strParams = "{\"PhoneNumberSet\":[\"+8618538705067\"],\"TemplateID\":\"186797\",\"Sign\":\"江南艺考\",\"TemplateParamSet\":[\"王彤\",\"最近学习好\",\"成绩提升很快\"],\"SmsSdkAppid\":\"1466134967\"}";
                req = SendSmsRequest.FromJsonString<SendSmsRequest>(strParams);

                SendSmsResponse resp = client.SendSms(req).ConfigureAwait(false).GetAwaiter().GetResult(); ;
                Logger.Info(AbstractModel.ToJsonString(resp));
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString());
            }

        }
    }
}
