﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tono;
using Tono.GuiWinForm;

namespace TalkLoggerWinform
{
    public class FeaturePlayButton : FeatureControlBridgeBase
    {
        private CheckBox Btn;
        private DataHot Hot => (DataHot)base.Data;

        public override void OnInitInstance()
        {
            base.OnInitInstance();

            Btn = GetControl("checkBoxStart") as CheckBox;
            Btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Hot.IsPlaying = !Hot.IsPlaying;
            Btn.Checked = Hot.IsPlaying;
            if (Hot.IsPlaying)
            {
                LOG.WriteLine(LLV.INF, $"STARTED at {DateTime.Now.ToString(TimeUtil.FormatYMDHMSms)}");
            }
            else
            {
                LOG.WriteLine(LLV.INF, $"STOPPED at {DateTime.Now.ToString(TimeUtil.FormatYMDHMSms)}");
            }
        }
    }
}