﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentV2.Constants.Const;
using TalentV2.Constants.Enum;
using TalentV2.Notifications.Komu.Dtos;
using TalentV2.Notifications.Templates.Dtos;

namespace TalentV2.Notifications.Templates
{
    public static class TemplateHelper
    {
        public static string AcceptedOfferTemplate(CandidateOfferAcceptedTemplate input, bool isFirstAcceptedOffer = true) =>
        $"#{input.CVId} **{input.FullName}** " +
            $"will onboard on {(!string.IsNullOrEmpty(input.OnboardDate) ? ("**" + input.OnboardDate + "**") : "")} with following info {(isFirstAcceptedOffer ? "" : "**[UPDATE]**")}: \n" +
            $"```"+
            $"User type: {input.UserTypeName} \n" +
            $"Branch: {input.BranchName} \n" + 
            $"Phone: {input.Phone} \n" + 
            $"Email: {input.Email} \n" +
            $"NCC Email: {input.NCCEmail ?? "(empty)"} \n" +
            $"```";

        public static string RejectedOfferTemplate(CandidateOfferAcceptedTemplate input) =>
            $"**[CANCELLED]** #{input.CVId} **{input.FullName}** will onboard on {input.OnboardDate}";

        public static string UpdatedPersonalInfoTemplate(CandidateOfferAcceptedTemplate input) =>
            $"#{input.CVId} **{input.FullName}** " +
            $"will onboarding on **{input.OnboardDate}** has been changed with following info: \n" +
            $"```" +
            $"User type: {input.UserTypeName} \n" +
            $"Branch: {input.BranchName} \n" +
            $"Phone: {input.Phone} \n" +
            $"Email: {input.Email} \n" +
            $"NCC Email: {input.NCCEmail ?? "(empty)"} \n" +
            $"```";

        public static string RequestInternFromProject(MessageNotificationRequestFromProject input) =>
            $"{input.UserType.ToString()} Requisition #{input.RequestId} **{input.BranchName}** {input.SubPositionName} has been created by Project tool with note:" +
            $"```{input.Note}```" + 
            $"{input.URL}";
        public static string RequestStaffFromProject(MessageNotificationRequestFromProject input) =>
            $"{input.UserType.ToString()} Requisition #{input.RequestId} **{input.BranchName}** {input.SubPositionName} **{input.Level.ToString()}** has been created by Project tool with note:" +
            $"```{input.Note}```" +
            $"{input.URL}";
        public static string ContentEmailTemplate(MailFuncEnum type) =>
            type switch
            {
                MailFuncEnum.AcceptedOfferJob => "<div dir='ltr'> <p><strong>THƯ&nbsp;MỜI&nbsp;NHẬN&nbsp;VIỆC</strong></p> <p><strong>Th&acirc;n gửi: {{FullName}}</strong></p> <p>Trước ti&ecirc;n, xin cảm ơn bạn đ&atilde; d&agrave;nh thời gian tham gia buổi phỏng vấn với c&ocirc;ng ty. Dựa tr&ecirc;n kết quả của cuộc phỏng vấn, c&ocirc;ng ty rất vui mừng&nbsp;mời&nbsp;bạn gia nhập ng&ocirc;i nh&agrave; chung&nbsp;<strong>NCC</strong>.</p> <p>Dưới đ&acirc;y l&agrave; một số th&ocirc;ng tin cơ bản về vị tr&iacute;&nbsp;l&agrave;m&nbsp;việc&nbsp;của bạn:</p> <p><strong>I.Th&ocirc;ng tin chung</strong></p> <p>&middot; Vị tr&iacute; l&agrave;m việc: {{JobPositionRecruit}}</p> <p>&middot; Thời gian thử&nbsp;việc: 02 th&aacute;ng</p> <p>&middot; Thời gian&nbsp;nhận&nbsp;việc:&nbsp;<strong>9h00, {{OnboardDay}} ng&agrave;y {{OnboardDate}}.</strong></p> <p>&middot; Thời gian l&agrave;m việc: S&aacute;ng từ 8h30 - 12h00; Chiều từ 13h00 - 17h30 (c&oacute; thể thay đổi)</p> <p>&middot; Địa điểm l&agrave;m việc: {{CVBranchAddress}}.</p> <p><strong>II.Chế độ đ&atilde;i ngộ kh&aacute;c</strong></p> <p>&middot; Mức lương ch&iacute;nh thức: {{SalaryToString}} VNĐ/ th&aacute;ng.(theo giờ l&agrave;m việc thực tế)</p> <p>&middot; Hỗ trợ ăn trưa: {{LaunchAllowance}} VNĐ (theo giờ&nbsp;l&agrave;m&nbsp;việc&nbsp;thực tế)</p> <p>&middot; <strong>Tổng lương: {{TotalSalary}} VNĐ/ th&aacute;ng.</strong>&nbsp;</p> <p>&middot; Mức lương thử&nbsp;việc&nbsp;= {{Percentage}} mức lương ch&iacute;nh thức.</p> <p>&middot; Được tham gia c&aacute;c hoạt động seminar v&agrave; teambuilding của c&ocirc;ng ty, sinh nhật nh&acirc;n vi&ecirc;n tổ chức h&agrave;ng th&aacute;ng.</p> <p>&middot; C&aacute;c chế độ kh&aacute;c đầy đủ theo luật lao động hiện h&agrave;nh.</p> <p>Bạn vui l&ograve;ng mang theo Laptop c&aacute; nh&acirc;n v&agrave; hồ sơ bao gồm:&nbsp;<strong>chứng minh&nbsp;thư&nbsp;c&ocirc;ng chứng,&nbsp;giấy&nbsp;khai sinh c&ocirc;ng chứng, sổ hộ khẩu c&ocirc;ng chứng v&agrave; CV c&oacute; ảnh</strong>&nbsp;khi tới&nbsp;nhận&nbsp;việc&nbsp;tại c&ocirc;ng ty.</p> <p>Nếu c&oacute; bất cứ thắc mắc g&igrave; về đề nghị c&ocirc;ng ty đưa ra, bạn vui l&ograve;ng phản hồi qua email<strong>:&nbsp;</strong><a><strong>{{HREmail}}</strong></a>&nbsp;hoặc li&ecirc;n hệ qua số:&nbsp;<strong>024.6687.4606 - {{HRPhone}}</strong><strong> (Ms {{HRName}})</strong></p> <p><strong>NCC Tr&acirc;n trọng!</strong>&nbsp;</p> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p><em>THANKS AND BEST REGARDS,&nbsp;</em></p> <p><em><strong>------------------------------<wbr />----------------------</strong></em></p> <p>{{SignatureContact}}</p> </div> </div> </div> </div>",
                MailFuncEnum.FailedInterview => "<div class=''> <div id=':kb' tabindex='-1'><strong style='font-family: arial, sans-serif;'>Dear bạn {{FullName}},</strong></div> <div id=':k0' class='ii gt'> <div id=':kc' class='a3s aiL '> <div dir='ltr'> <div dir='ltr'>&nbsp;</div> <div dir='ltr'> <div dir='ltr' style='font-variant-numeric: normal; font-variant-east-asian: normal; background-color: transparent;'><span style='font-family: arial,sans-serif;'><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>C&ocirc;ng ty NCC c&aacute;m ơn bạn đ&atilde; quan t&acirc;m v&agrave; tham gia phỏng vấn tại C&ocirc;ng ty với vị tr&iacute; {{JobPositionRecruit}}<strong>.</strong><br /><br /></span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>Trong buổi phỏng vấn bạn đ&atilde; thể hiện kh&aacute; tốt v&agrave; c&ocirc;ng ty rất ấn tượng với kỹ năng, th&agrave;nh t&iacute;ch bạn đ&atilde; đạt&nbsp;</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>được, tuy nhi&ecirc;n sau khi c&acirc;n nhắc kỹ lưỡng, </span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>ch&uacute;ng t&ocirc;i rất tiếc phải th&ocirc;ng b&aacute;o rằng: tại thời điểm n&agrave;y,&nbsp;</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>bạn </span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; font-weight: bold; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>chưa thực sự ph&ugrave; hợp</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'> với c&aacute;c ti&ecirc;u ch&iacute; tuyển dụng của c&ocirc;ng ty.<br /><br /></span></span></div> <div dir='ltr' style='font-variant-numeric: normal; font-variant-east-asian: normal; background-color: transparent;'><span style='font-family: arial,sans-serif;'><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>Trong tương lai, ch&uacute;ng t&ocirc;i hy vọng bạn sẽ thường xuy&ecirc;n cập nhật c&aacute;c cơ hội việc l&agrave;m của NCC v&agrave; sẽ&nbsp;</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>ứng tuyển v&agrave;o c&aacute;c vị tr&iacute; ph&ugrave; hợp với kiến thức v&agrave; kinh nghiệm của bạn. </span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>C&ocirc;ng ty sẽ lưu hồ sơ bạn để&nbsp;</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>lưu &yacute; cho c&aacute;c lần tuyển dụng tiếp theo. </span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>Ch&uacute;ng t&ocirc;i đ&aacute;nh gi&aacute; cao sự quan t&acirc;m của bạn đối NCC v&agrave; mong&nbsp;</span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>bạn sẽ thật sự th&agrave;nh c&ocirc;ng trong mục ti&ecirc;u nghề nghiệp của m&igrave;nh!&nbsp;<br /><br /></span></span></div> <div dir='ltr' style='font-variant-numeric: normal; font-variant-east-asian: normal; background-color: transparent;'><span style='font-family: arial,sans-serif;'><span style='font-variant-numeric: normal; font-variant-east-asian: normal; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>Tr&acirc;n trọng,&nbsp;<br /><br /></span><span style='font-variant-numeric: normal; font-variant-east-asian: normal; font-weight: bold; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;'>Bộ phận Nh&acirc;n sự &ndash; C&ocirc;ng ty NCC</span></span></div> </div> <div> <div dir='ltr'> <div dir='ltr'> <p><span style='color: #ff0000; font-family: arial, helvetica, sans-serif; font-size: xx-small;'><em>THANKS AND BEST REGARDS,&nbsp;</em></span></p> <p style='color: #000000;'><em style='font-family: Lato;'><span style='line-height: 16.1px;'><span style='font-family: arial, helvetica, sans-serif;'><strong>------------------------------<wbr />----------------------</strong></span></span></em></p> </div> </div> </div> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p style='color: #222222; font-size: 14px; min-height: 14px; font-stretch: normal;'>{{SignatureContact}}</p> </div> </div> </div> </div> <div class='yj6qo'>&nbsp;</div> <div class='adL'>&nbsp;</div> </div> </div> <div id=':ll' class='ii gt' style='display: none;'> <div id=':lm' class='a3s aiL '>&nbsp;</div> </div> <div class='hi'>&nbsp;</div> </div>",
                MailFuncEnum.FailedCV => "<div class=''> <div id=':j8' class='ii gt'> <div id=':jz' class='a3s aiL '> <div dir='ltr'> <div style='font-family: Tahoma;'> <p style='font-weight: 1000;'>Th&acirc;n gửi bạn {{FullName}}</p> <p>NCC cảm ơn bạn đ&atilde; quan t&acirc;m v&agrave; ứng tuyển v&agrave;o C&ocirc;ng ty. C&ocirc;ng ty đ&aacute;nh gi&aacute; cao kinh nghiệm cũng như năng lực của bạn. Tuy nhi&ecirc;n sau khi c&acirc;n nhắc kỹ lưỡng, ch&uacute;ng t&ocirc;i rất tiếc phải th&ocirc;ng b&aacute;o rằng: tại thời điểm n&agrave;y, bạn chưa thực sự ph&ugrave; hợp với c&aacute;c ti&ecirc;u ch&iacute; tuyển dụng của c&ocirc;ng ty.</p> <p>Trong tương lai, ch&uacute;ng t&ocirc;i hy vọng bạn sẽ thường xuy&ecirc;n cập nhật c&aacute;c cơ hội việc l&agrave;m của NCC tại&nbsp;<a href='https://career.ncc.asia/' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://career.ncc.asia/&amp;source=gmail&amp;ust=1654052027456000&amp;usg=AOvVaw0c0RKCUAfdhEBD6ftpnIDI'>https://career.ncc.asia/</a>. C&ocirc;ng ty sẽ lưu CV của bạn v&agrave; xin ph&eacute;p li&ecirc;n hệ lại với bạn khi c&oacute; cơ hội ph&ugrave; hợp.</p> <p>Ch&uacute;c bạn th&agrave;nh c&ocirc;ng.</p> </div> <div style='font-family: Tahoma;'> <p style='font-weight: 1000;'>NCC Tr&acirc;n trọng!</p> <p style='font-style: italic; color: red;'>THANKS AND BEST REGARDS,</p> <br /> <p style='font-weight: 1000;'>Bộ phận Nh&acirc;n sự - C&ocirc;ng ty NCC</p> <div style='font-style: italic; font-weight: 1000;'> <p>------------------------------<wbr />----------------------</p> </div> </div> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p style='color: #222222; font-size: 14px; min-height: 14px; font-stretch: normal;'>{{SignatureContact}}</p> </div> </div> </div> </div> </div> </div> </div> <div class=''> <div id=':l5' class='ii gt' style='display: none;'> <div id=':l6' class='a3s aiL '>&nbsp;</div> </div> <div class='hi'>&nbsp;</div> </div>",
                MailFuncEnum.AcceptedOfferInternship => "<div class=''> <div id=':kl' class='ii gt'> <div id=':j9' class='a3s aiL '> <div dir='ltr'> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 15.69px; background-color: transparent; text-align: center;' align='center'><strong style='margin: 0px;'>THƯ&nbsp;MỜI&nbsp;THỰC&nbsp;TẬP</strong></p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; line-height: 15.69px; background-color: transparent; text-align: center;' align='center'><strong>Th&acirc;n gửi: {{FullName}}</strong></p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; text-align: justify;'>Trước ti&ecirc;n, xin cảm ơn bạn đ&atilde; d&agrave;nh thời gian tham gia buổi phỏng vấn với c&ocirc;ng ty. Dựa tr&ecirc;n kết quả của cuộc phỏng vấn, c&ocirc;ng ty rất vui mừng&nbsp;mời&nbsp;bạn gia nhập ng&ocirc;i nh&agrave; chung&nbsp;<strong>NCC</strong>.</p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; text-align: justify;'>Dưới đ&acirc;y l&agrave; một số th&ocirc;ng tin cơ bản về vị tr&iacute;&nbsp;l&agrave;m&nbsp;việc&nbsp;của bạn:</p> <p class='MsoNormal' style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent;'><strong style='margin: 0px;'>I. Th&ocirc;ng tin chung</strong></p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>&middot; Vị tr&iacute;&nbsp;l&agrave;m&nbsp;việc:&nbsp;<strong>Thực Tập Sinh {{JobPositionRecruit}}</strong></p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>&middot; Thời gian&nbsp;nhận&nbsp;việc:&nbsp;<strong>9h00 {{OnboardDay}} ng&agrave;y {{OnboardDate}}.</strong></p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>&middot; Thời gian l&agrave;m việc: S&aacute;ng từ 8h30 - 12h00; Chiều từ 13h00 - 17h30 (c&oacute; thể thay đổi).</p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>&middot; Địa điểm l&agrave;m việc: {{CVBranchAddress}}.</p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent;'><strong style='margin: 0px;'>II. Chế độ đ&atilde;i ngộ kh&aacute;c</strong></p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>. Hỗ trợ lương: {{SalaryToString}} VNĐ/th&aacute;ng (theo giờ l&agrave;m việc thực tế).</p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>. Hỗ trợ Ăn trưa: {{LaunchAllowance}} VNĐ/th&aacute;ng (theo giờ l&agrave;m&nbsp;việc&nbsp;thực&nbsp;tế).</p> <p style='font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent; margin: 0px 0px 0px 48px;'>&middot; &nbsp;Được&nbsp;đ&agrave;o tạo training những kiến&nbsp;thức&nbsp;cơ bản, chuy&ecirc;n s&acirc;u. C&oacute; cơ hội trở th&agrave;nh&nbsp;nh&acirc;n&nbsp;vi&ecirc;n&nbsp;ch&iacute;nh&nbsp;thức.</p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent;'>Bạn vui l&ograve;ng mang theo Laptop c&aacute;&nbsp;nh&acirc;n&nbsp;(N&ecirc;n sử dụng ổ SSD để n&acirc;ng cao hiệu quả c&ocirc;ng&nbsp;việc) v&agrave; hồ sơ bao gồm:&nbsp;<strong>chứng minh&nbsp;thư&nbsp;c&ocirc;ng chứng,&nbsp;giấy&nbsp;khai sinh c&ocirc;ng chứng, sổ hộ khẩu c&ocirc;ng chứng v&agrave; CV c&oacute; ảnh</strong>&nbsp;khi tới&nbsp;nhận&nbsp;việc&nbsp;tại c&ocirc;ng ty.</p> <p class='MsoNormal' style='margin-bottom: 10.66px; font-variant-numeric: normal; font-variant-east-asian: normal; font-stretch: normal; font-size: 13.33px; line-height: 16.86px; background-color: transparent;'>Nếu c&oacute; bất cứ thắc mắc g&igrave; về đề nghị c&ocirc;ng ty đưa ra, bạn vui l&ograve;ng phản hồi qua email<strong>:&nbsp;</strong><a style='color: #0000ff;' href='mailto:info@ncc.asia' target='_blank' rel='noreferrer'><strong>{{HREmail}}</strong></a>&nbsp;hoặc li&ecirc;n hệ qua số:&nbsp;<strong>024.6687.4606 - {{HRPhone}}</strong> (Ms. {{HRName}})</p> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p style='color: #222222;'><em>THANKS AND BEST REGARDS,&nbsp;</em></p> <p style='color: #000000;'><em style='font-family: Lato;'><strong>------------------------------<wbr />----------------------</strong></em></p> </div> </div> </div> </div> </div> </div> </div> <div class=''> <div id=':k0' class='ii gt'> <div id=':kc' class='a3s aiL '> <div dir='ltr'> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p style='color: #222222; font-size: 14px; min-height: 14px; font-stretch: normal;'>{{SignatureContact}}</p> </div> </div> </div> </div> </div> </div> </div>",
                MailFuncEnum.ScheduledInterview => "<div dir='ltr'> <p dir='ltr'><strong>Dear bạn {{FullName}}, </strong></p> <br /> <p dir='ltr'>Qua qu&aacute; tr&igrave;nh chọn lọc, ch&uacute;ng t&ocirc;i nhận thấy hồ sơ của bạn ph&ugrave; hợp với vị tr&iacute; {{JobPositionRecruit}}. V&igrave; vậy, C&ocirc;ng ty tr&acirc;n trọng k&iacute;nh mời bạn tham dự phỏng vấn online với th&ocirc;ng tin cụ thể như sau:</p> <p dir='ltr'>Vị tr&iacute; ứng tuyển: <strong>{{JobPositionRecruit}}</strong></p> <p dir='ltr'>Văn ph&ograve;ng: {{CVBranchName}} tại {{CVBranchAddress}}</p> <p dir='ltr'>Thời gian: {{InterviewTime}}, {{InterviewDay}} ng&agrave;y {{InterviewDate}}</p> <br /> <p>H&igrave;nh thức: Phỏng vấn online qua Google Meet</p> &nbsp;<br /> <p dir='ltr'>Rất mong bạn thu xếp thời gian tham gia. Vui l&ograve;ng x&aacute;c nhận lại với ch&uacute;ng t&ocirc;i theo số điện thoại 024.6687.<a title='Click-to-Call4606 - 077' href='https://mail.google.com/mail/u/0/4606%20-%20077' target='_blank' rel='4606 - 077'>4606 - {{HRPhone}}</a> (Ms. {{HRName}}) hoặc qua email <a>{{HREmail}}</a> n&agrave;y về sự c&oacute; mặt của bạn k&egrave;m theo CV c&aacute; nh&acirc;n.</p> <br /> <p dir='ltr'>Nếu c&oacute; sự trở ngại về mặt thời gian, bạn cũng c&oacute; thể th&ocirc;ng b&aacute;o với ch&uacute;ng t&ocirc;i theo th&ocirc;ng tin tr&ecirc;n.&nbsp;<br />Tr&acirc;n trọng.</p> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p><em>THANKS AND BEST REGARDS,&nbsp;</em></p> <p><em><strong>------------------------------<wbr />----------------------</strong></em></p> <p>{{SignatureContact}}</p> </div> </div> </div> </div>",
                MailFuncEnum.ScheduledTest => "<div dir='ltr'> <p dir='ltr'><strong>Dear bạn {{FullName}} </strong></p> <br /> <p dir='ltr'>Qua qu&aacute; tr&igrave;nh chọn lọc, ch&uacute;ng t&ocirc;i nhận thấy hồ sơ của bạn ph&ugrave; hợp với vị tr&iacute; <strong>{{JobPositionRecruit}}</strong>. V&igrave; vậy, C&ocirc;ng ty tr&acirc;n trọng k&iacute;nh mời bạn tham gia l&agrave;m b&agrave;i test online với th&ocirc;ng tin cụ thể như sau:</p> <p dir='ltr'>Vị tr&iacute; ứng tuyển: <strong>{{JobPositionRecruit}}</strong></p> <p dir='ltr'>Văn ph&ograve;ng: {{CVBranchName}} tại {{CVBranchAddress}}</p> <p dir='ltr'>Thời gian l&agrave;m Test Online: Trước ?? Thứ ?? ng&agrave;y ?? th&aacute;ng ?? năm ??</p> <p dir='ltr'>{{LMSInfo}}</p> <p><strong>Một v&agrave;i lưu &yacute; về&nbsp;b&agrave;i&nbsp;online&nbsp;test&nbsp;v&agrave; v&ograve;ng phỏng vấn m&agrave; bạn cần biết:</strong></p> <p>➤ Online Test k&eacute;o d&agrave;i 50 ph&uacute;t trắc nghiệm v&agrave; tối đa 6 tiếng cho b&agrave;i code , được sử dụng t&agrave;i liệu trong qu&aacute; tr&igrave;nh l&agrave;m b&agrave;i.</p> <p>➤ B&agrave;i Test được l&agrave;m được 3 lần.</p> &nbsp;<br /> <p dir='ltr'>Rất mong bạn thu xếp thời gian tham gia. Vui l&ograve;ng x&aacute;c nhận lại với ch&uacute;ng t&ocirc;i theo số điện thoại 024.6687.<a title='Click-to-Call4606 - 077' href='https://mail.google.com/mail/u/0/4606%20-%20077' target='_blank' rel='4606 - 077'>4606 - </a>{{HRPhone}} (Ms. {{HRName}}) hoặc qua email <a>{{HREmail}}</a> n&agrave;y về sự c&oacute; mặt của bạn k&egrave;m theo CV c&aacute; nh&acirc;n.</p> <br /> <p dir='ltr'>Nếu c&oacute; sự trở ngại về mặt thời gian, bạn cũng c&oacute; thể th&ocirc;ng b&aacute;o với ch&uacute;ng t&ocirc;i theo th&ocirc;ng tin tr&ecirc;n.&nbsp;</p> <p dir='ltr'><br />Tr&acirc;n trọng.</p> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p><em>THANKS AND BEST REGARDS,&nbsp;</em></p> <p><em><strong>------------------------------<wbr />----------------------</strong></em></p> </div> </div> </div> </div> <p>{{SignatureContact}}</p>",
                MailFuncEnum.FailedTest => "<div> <p>Th&acirc;n bạn {{FullName}}</p> <p>NCC cảm ơn bạn đ&atilde; quan t&acirc;m v&agrave; tham gia l&agrave;m b&agrave;i Test tại C&ocirc;ng ty. C&ocirc;ng ty đ&aacute;nh gi&aacute; cao kinh nghiệm cũng như năng lực của bạn. Tuy nhi&ecirc;n sau khi c&acirc;n nhắc kỹ lưỡng, ch&uacute;ng t&ocirc;i rất tiếc phải th&ocirc;ng b&aacute;o rằng: tại thời điểm n&agrave;y, bạn chưa thực sự ph&ugrave; hợp với c&aacute;c ti&ecirc;u ch&iacute; tuyển dụng của c&ocirc;ng ty.</p> <p>Trong tương lai, ch&uacute;ng t&ocirc;i hy vọng bạn sẽ thường xuy&ecirc;n cập nhật c&aacute;c cơ hội việc l&agrave;m của NCC tại <a href='https://career.ncc.asia' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://career.ncc.asia&amp;source=gmail&amp;ust=1656986694657000&amp;usg=AOvVaw12XrKezxjDfRjvarQf-xHM'>https://career.ncc.asia/</a>. C&ocirc;ng ty sẽ lưu CV của bạn v&agrave; xin ph&eacute;p li&ecirc;n hệ lại với bạn khi c&oacute; cơ hội ph&ugrave; hợp.</p> <p>Ch&uacute;c bạn th&agrave;nh c&ocirc;ng.</p> </div> <div> <p>NCC Tr&acirc;n trọng!</p> <p>THANKS AND BEST REGARDS,</p> <br /> <p>Bộ phận Nh&acirc;n sự - C&ocirc;ng ty NCC</p> <div> <p>------------------------------<wbr />----------------------</p> <p>{{SignatureContact}}</p> </div> </div>",
                MailFuncEnum.RejectedOffer => "<div> <p>Th&acirc;n g&#7917;i b&#7841;n<strong> {{FullName}} </strong></p> <p>C&#7843;m &#417;n b&#7841;n &#273;&atilde; quan t&acirc;m v&agrave; d&agrave;nh th&#7901;i gian tham gia bu&#7893;i ph&#7887;ng v&#7845;n v&#7899;i v&#7883; tr&iacute; {{JobPositionRecruit}} t&#7841;i C&ocirc;ng ty C&#7893; ph&#7847;n NCCPLUS Vi&#7879;t Nam. </p> <p> C&ocirc;ng ty &#273;&aacute;nh gi&aacute; cao kinh nghi&#7879;m c&#361;ng nh&#432; n&#259;ng l&#7921;c c&#7911;a b&#7841;n. M&#7863;c d&ugrave; t&#7841;i th&#7901;i &#273;i&#7875;m n&agrave;y, b&#7841;n {{FullName}} v&agrave; NCCPLUS Vi&#7879;t Nam ch&#432;a th&#7875; h&#7907;p t&aacute;c nh&#432; k&#7923; v&#7885;ng nh&#432;ng hy v&#7885;ng b&#7841;n {{FullName}} s&#7869; lu&ocirc;n th&#7853;t th&agrave;nh c&ocirc;ng, vui v&#7867; v&agrave; ch&uacute;ng ta s&#7869; s&#7899;m c&oacute; c&#417; h&#7897;i &#273;&#7891;ng h&agrave;nh trong t&#432;&#417;ng lai g&#7847;n.</p> <p>C&ocirc;ng ty hy v&#7885;ng b&#7841;n {{FullName}} s&#7869; th&#432;&#7901;ng xuy&ecirc;n c&#7853;p nh&#7853;t c&aacute;c c&#417; h&#7897;i vi&#7879;c l&agrave;m c&#7911;a NCC t&#7841;i <a href='https://career.ncc.asia' target='_blank' data-saferedirecturl='https://www.google.com/url?q=https://career.ncc.asia&amp;source=gmail&amp;ust=1656986694657000&amp;usg=AOvVaw12XrKezxjDfRjvarQf-xHM'>https://career.ncc.asia/</a>. C&ocirc;ng ty sẽ lưu CV của bạn v&agrave; xin ph&eacute;p li&ecirc;n hệ lại với bạn khi c&oacute; cơ hội ph&ugrave; hợp.</p> <p>Ch&uacute;c bạn th&agrave;nh c&ocirc;ng.</p> </div> <div> <p>NCC Tr&acirc;n trọng!</p> <p>THANKS AND BEST REGARDS,</p> <p>Bộ phận Nh&acirc;n sự - C&ocirc;ng ty NCC</p> <div> <p>------------------------------<wbr />----------------------</p> <p>{{SignatureContact}}</p> </div> </div>",
                _ => string.Empty
            };
        public static string ContentLMSInfo(string username, string password, string lmsCourseName, Guid courseInstanceId)
            => $"<div dir='ltr'>   <p dir='ltr'>Link b&agrave;i Test: <strong><a href='{TalentConstants.LMSClientRootAddress}app/student/course/{courseInstanceId}'>{lmsCourseName}</a></strong></p> <p dir='ltr'>Username: {username}</p> <p dir='ltr'>Pass: {password}</p> </div>";

        public static string DefaulSignature =>
            "<div> <div dir='ltr'> <div> <div dir='ltr' data-smartmail='gmail_signature'> <div dir='ltr'> <p><em><strong>NGUYEN HONG HR</strong></em></p> <p><strong><em>[A]:&nbsp;Human Resource Department</em></strong></p> <p><strong><em>Floor 5,</em></strong><strong><em>&nbsp;Ecolife Building, No.58 To Huu Street, Nam Tu Liem District, Ha Noi</em></strong><u></u></p> <p><em><strong>[P]</strong>:<strong>077.33.11.272</strong></em></p> <p><strong>[</strong><strong>E]:&nbsp;</strong><strong><a href='mailto:van.nguyenhong@ncc.asia' target='_blank'>hr.nguyenhong@ncc.asia</a></strong></p> </div> </div> </div> </div> </div>";
    }
}
