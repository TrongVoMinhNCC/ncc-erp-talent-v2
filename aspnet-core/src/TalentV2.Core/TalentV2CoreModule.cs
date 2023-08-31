using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MailKit;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Threading.BackgroundWorkers;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using TalentV2.Authorization.Roles;
using TalentV2.Authorization.Users;
using TalentV2.BackgroundWorker;
using TalentV2.Configuration;
using TalentV2.Localization;
using TalentV2.MultiTenancy;
using TalentV2.Notifications.Mail;
using TalentV2.Timing;

namespace TalentV2
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class TalentV2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Logger.Info("PreInitialize() start");
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);
            //Configuration.BackgroundJobs.IsJobExecutionEnabled = true;
            TalentV2LocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = TalentV2Consts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();

            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));

            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = TalentV2Consts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = TalentV2Consts.DefaultPassPhrase;

            Logger.Info("PreInitialize() done");
        }

        public override void Initialize()
        {
            Logger.Info("Initialize() start");
            IocManager.RegisterAssemblyByConvention(typeof(TalentV2CoreModule).GetAssembly());
            Logger.Info("Initialize() done");
        }
       
    }
}
