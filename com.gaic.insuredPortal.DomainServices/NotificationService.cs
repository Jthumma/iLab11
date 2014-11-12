using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class NotificationService : INotificationService
    {
        public List<NotificationModel> GetNotifications(UserModel loggedInUser)
        {
            var messages = new List<NotificationModel>();

            if (loggedInUser.Roles.Contains(RoleItemModel.Insured))
            {
                messages.Add(new NotificationModel
                {
                    Category = MessageCategory.Policy.ToString(),
                    Message = "A change has been made to your policy 2345671"
                });
                messages.Add(new NotificationModel
                {
                    Category = MessageCategory.Billing.ToString(),
                    Message = "You have new bill"
                });
                messages.Add(new NotificationModel
                {
                    Category = MessageCategory.Claims.ToString(),
                    Message = "Your claim #1234567 has been approved"
                });
            }
            return messages;
        }
    }
}