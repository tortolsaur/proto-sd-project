﻿namespace Consultation.App.Views.IViews
{
    public interface IMainView
    {
        event EventHandler DashboardEvent;
        event EventHandler ConsultationEvent;
        event EventHandler BulletinEvent;
        event EventHandler SFManagementEvent;
        event EventHandler ReportsEvent;
        event EventHandler PreferenceEvent;

        void Header(string header);
        void SetMessage(string message);
    }
}
