using Abp.Configuration;
using System.Collections.Generic;

namespace TalentV2.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition
                (
                    AppSettingNames.UiTheme,
                    "red",
                    scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User,
                    clientVisibilityProvider: new VisibleSettingClientVisibilityProvider()
                ),
                new SettingDefinition
                (
                    AppSettingNames.GoogleClientAppId,
                    "",
                    scopes:SettingScopes.Application| SettingScopes.Tenant
                ),

                #region KomuDiscord
                new SettingDefinition
                (
                    AppSettingNames.KomuHRITChannelId,
                    "",
                    scopes:SettingScopes.Application| SettingScopes.Tenant
                ),
                new SettingDefinition
                (
                    AppSettingNames.KomuResourceRequestInternChannelId,
                    "",
                    scopes:SettingScopes.Application| SettingScopes.Tenant
                ),
                new SettingDefinition
                (
                    AppSettingNames.KomuResourceRequestStaffChannelId,
                    "",
                    scopes:SettingScopes.Application| SettingScopes.Tenant
                ),
                new SettingDefinition
                (
                    AppSettingNames.TalentSecurityCode,
                    "",
                    scopes:SettingScopes.Application| SettingScopes.Tenant
                ),
                #endregion 

                #region NotifyInterViewing
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewStartAtHour,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewEndAtHour,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewMinutes,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewResultMinutes,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.IsNoticeInterviewViaChannel,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewScheduleChannel,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.NoticeInterviewResultChannel,
                    "",
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                #endregion

                #region Internal Tools
                new SettingDefinition(
                    AppSettingNames.HRMURLSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.HRMSecurityCodeSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.ProjectURLSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.ProjectSecurityCodeSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.TimesheetURLSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.TimesheetAutoUpdateSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.TimesheetSecurityCodeSetting,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                #endregion

                new SettingDefinition(
                    AppSettingNames.GoogleClientAppEnable,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
                new SettingDefinition(
                    AppSettingNames.EnableNormalLogin,
                    "" ,
                    scopes:SettingScopes.Application | SettingScopes.Tenant
                ),
            };
        }
    }
}
