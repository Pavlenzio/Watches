﻿using Watches.Utilities;

namespace Watches;

[RegisterTypeInIl2Cpp(false)]
public class DisplayTime : MonoBehaviour
{

#nullable disable
    UILabel m_LabelDisplayTime;
    TimeOfDay m_TimeOfDay;
#nullable enable

    void Awake() => InitializeComponents();

    void ConfigureComponents()
    {
        UserInterfaceUtilities.SetupUILabel(m_LabelDisplayTime, "", FontStyle.Normal, UILabel.Crispness.Always, NGUIText.Alignment.Automatic, UILabel.Overflow.ResizeHeight, false, 20, 20, Color.white, true);
    }

    void InitializeComponents()
    {
        m_TimeOfDay = GameManager.GetTimeOfDayComponent();
        m_LabelDisplayTime = UserInterfaceUtilities.SetupGameObjectUILabel("DigitalTime", transform, false, 0, 13, 0);
        ConfigureComponents();
    }

    void Update()
    {
        m_LabelDisplayTime.text = m_TimeOfDay.GetHour() + ":" + m_TimeOfDay.GetMinutes().ToString("D2");
    }
}