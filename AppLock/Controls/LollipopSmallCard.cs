﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LollipopSmallCard : Control
{

    #region Variables
  
    FontManager font = new FontManager();
    Image image;

    string fontcolor = "#33b679";
    string information = "Info";

    Color BgColor = ColorTranslator.FromHtml("#323232");
    Color StringColor;
    Color ThumbnailBGColor = ColorTranslator.FromHtml("#191919");
    Color BorderColor = ColorTranslator.FromHtml("#323232");

    #endregion
    #region Properties

    [Category("Appearance")]
    public Image Image
    {
        get
        {
            return image;
        }
        set
        {
            image = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public string FontColor
    {
        get { return fontcolor; }
        set
        {
            fontcolor = value;
            Invalidate();
        }
    }
    [Category("Appearance")]
    public string Info
    {
        get { return information; }
        set
        {
            information = value;
            Invalidate();
        }
    }

    [Browsable(false)]
    public Font Font
    {
        get { return base.Font; }
        set { base.Font = value; }
    }

    [Browsable(false)]
    public Color ForeColor
    {
        get { return base.ForeColor; }
        set { base.ForeColor = value; }
    }

    #endregion
    #region Events

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 52;
    }

    #endregion

    public LollipopSmallCard()
    {
        Height = 52; Width = 182; DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics G = e.Graphics;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.Clear(Parent.BackColor);

        StringColor = ColorTranslator.FromHtml(fontcolor);

        var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 3, 1);
        var ThumbnailBG = DrawHelper.CreateLeftRoundRect(1, 1, 50, 49, 1);

        G.FillPath(new SolidBrush(BgColor), BG);
        G.DrawPath(new Pen(BorderColor), BG);

        G.FillPath(new SolidBrush(ThumbnailBGColor), ThumbnailBG);
        G.DrawPath(new Pen(ThumbnailBGColor), ThumbnailBG);

        if (image != null)
        { G.DrawImage(image, 3, 3, 45, 45); }
        if (Enabled)
        { G.DrawString(Text, font.Roboto_Medium10, new SolidBrush(StringColor), new PointF(58.6f, 9f)); }
        else
        { G.DrawString("Wait...", font.Roboto_Medium10, new SolidBrush(StringColor), new PointF(58.6f, 9f)); }

        G.TextRenderingHint = TextRenderingHint.AntiAlias;
        G.DrawString(information, font.Roboto_Regular9, new SolidBrush(ColorTranslator.FromHtml("#999999")), new PointF(59.1f, 26f));
    }
}
