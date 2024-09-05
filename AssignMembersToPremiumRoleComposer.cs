using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace NewUmbracoProject
{
    public class AssignMembersToPremiumRoleComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        => builder.AddNotificationHandler<MemberSavedNotification, AssignMembersToPremiumRoleHandler>();
    }
}

