﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using UIEditor.Entity;
using Structure.Control;
using UIEditor;
using UIEditor.Component;
using System.Drawing.Drawing2D;
using Structure;
using UIEditor.PropertyGridEditor;
using System.Drawing.Design;
using UIEditor.UserClass;
using Utils;

namespace UIEditor.Entity.Control
{
    [TypeConverter(typeof(SceneButtonNode.PropertyConverter))]
    [Serializable]
    public class SceneButtonNode : ControlBaseNode
    {
        #region 常量
        private const int PADDING = 2;
<<<<<<< HEAD
=======
        private const string NAME_IMAGEON = "ImageOn.png";
        private const string NAME_IMAGEOFF = "ImageOff.png";
>>>>>>> SationKNXUIEditor-Modify
        #endregion

        #region 变量
        private static int index = 0;
        private Image ImgImageOn
        {
            get
            {
                if (null != this.ImageOn)
                {
                    return ImageHelper.GetDiskImage(Path.Combine(MyCache.ProjImgPath, this.ImageOn));
                }

                return null;
            }
        }
        private Image ImgImageOff
        {
            get
            {
                if (null != this.ImageOff)
                {
                    return ImageHelper.GetDiskImage(Path.Combine(MyCache.ProjImgPath, this.ImageOff));
                }

                return null;
            }
        }
        #endregion

        #region 属性
        [EditorAttribute(typeof(PropertyGridKNXSelectedAddressSingleReadEditor), typeof(UITypeEditor)),
        TypeConverterAttribute(typeof(MultiSelectedAddressConverter))]
        public Dictionary<string, KNXSelectedAddress> ReadAddressId { get; set; }

        [EditorAttribute(typeof(PropertyGridKNXSelectedAddressMultiWriteEditor), typeof(UITypeEditor)),
        TypeConverterAttribute(typeof(MultiSelectedAddressConverter))]
        public Dictionary<string, KNXSelectedAddress> WriteAddressIds { get; set; }

        [EditorAttribute(typeof(PropertyGridStringImageEditor), typeof(UITypeEditor))]
        public string ImageOn { get; set; }

        /// <summary>
        /// 开启时控件的背景色
        /// </summary>
        public Color ColorOn { get; set; }

        [EditorAttribute(typeof(PropertyGridStringImageEditor), typeof(UITypeEditor))]
        public string ImageOff { get; set; }

        /// <summary>
        /// 关闭时控件的背景色
        /// </summary>
        public Color ColorOff { get; set; }

        public EBool IsGroup { get; set; }

        private int _DefaultValue;
        public int DefaultValue
        {
            get
            {
                return _DefaultValue;
            }
            set
            {
                if ((value >= 1) && (value <= 64))
                {
                    _DefaultValue = value;
                }
                else
                {
                    _DefaultValue = 1;

                    throw new Exception(UIResMang.GetString("Message49"));
                }
            }
        }
        #endregion

        #region 构造函数
        public SceneButtonNode()
            : base()
        {
            index++;

            this.Name = ImageKey = SelectedImageKey = MyConst.Controls.KnxSceneButtonType;

            this.Text = UIResMang.GetString("TextSceneButton");
            this.Title = UIResMang.GetString("TextSceneButton") + index;
            SetText(this.Title);

            this.Size = new Size(180, 40);
            this.FlatStyle = EFlatStyle.Stereo;

            this.Clickable = EBool.Yes;

            this.ReadAddressId = new Dictionary<string, KNXSelectedAddress>();
            this.WriteAddressIds = new Dictionary<string, KNXSelectedAddress>();

            this.ImageOn = ProjResManager.CopyImage(Path.Combine(MyCache.ProjectResImgDir, "on4.png"));
            this.ColorOn = this.BackgroundColor;

            this.ImageOff = ProjResManager.CopyImage(Path.Combine(MyCache.ProjectResImgDir, "off4.png"));
            this.ColorOff = this.BackgroundColor;

            this.IsGroup = EBool.No;
            this.DefaultValue = 1;
        }

        public SceneButtonNode(KNXSceneButton knx, BackgroundWorker worker)
            : base(knx, worker)
        {
            this.Name = ImageKey = SelectedImageKey = MyConst.Controls.KnxSceneButtonType;
            SetText(this.Title);

            this.ReadAddressId = knx.ReadAddressId ?? new Dictionary<string, KNXSelectedAddress>();
            this.WriteAddressIds = knx.WriteAddressIds ?? new Dictionary<string, KNXSelectedAddress>();

            if (ImportedHelper.IsLessThan2_0_3())
            {
                if (!string.IsNullOrEmpty(knx.ImageOn))
                {
                    this.ImageOn = ProjResManager.CopyImageSole(Path.Combine(this.ImagePath, knx.ImageOn));
                }
                if (!string.IsNullOrEmpty(knx.ImageOff))
                {
                    this.ImageOff = ProjResManager.CopyImageSole(Path.Combine(this.ImagePath, knx.ImageOff));
                }
            }
            else if(ImportedHelper.IsLessThan2_5_6())
            {
<<<<<<< HEAD
                File.Copy(Path.Combine(MyCache.ProjectResImgDir, this.ImageOn), FileImageOn);
=======
                this.ImageOn = ProjResManager.CopyImageSole(Path.Combine(this.ImagePath, NAME_IMAGEON));
                this.ImageOff = ProjResManager.CopyImageSole(Path.Combine(this.ImagePath, NAME_IMAGEOFF));
            }
            else
            {
                this.ImageOn = knx.ImageOn;
                this.ImageOff = knx.ImageOff;
>>>>>>> SationKNXUIEditor-Modify
            }

            this.ColorOn = ColorHelper.HexStrToColor(knx.ColorOn);
            this.ColorOff = ColorHelper.HexStrToColor(knx.ColorOff);
            this.IsGroup = (EBool)Enum.ToObject(typeof(EBool), knx.IsGroup);
            this.DefaultValue = knx.DefaultValue + 1;
        }

        public SceneButtonNode(KNXSceneButton knx, BackgroundWorker worker, string DirSrcImg)
            : this(knx, worker)
        {
            this.Id = GenId(); // 创建新的Id

            if (ImportedHelper.IsLessThan2_5_6())
            {
                string knxImage = GetImageName(knx.Id); // KNX图片资源名称
                string knxImagePath = Path.Combine(DirSrcImg, knxImage); // KNX图片资源路径

                this.ImageOn = ProjResManager.CopyImageRename(Path.Combine(knxImagePath, NAME_IMAGEON));
                this.ImageOff = ProjResManager.CopyImageRename(Path.Combine(knxImagePath, NAME_IMAGEOFF));
            }
            else
            {
<<<<<<< HEAD
                File.Copy(Path.Combine(MyCache.ProjectResImgDir, this.ImageOff), FileImageOff);
=======
                this.ImageOn = ProjResManager.CopyImageRename(Path.Combine(DirSrcImg, knx.ImageOn));
                this.ImageOff = ProjResManager.CopyImageRename(Path.Combine(DirSrcImg, knx.ImageOff));
>>>>>>> SationKNXUIEditor-Modify
            }
        }
        #endregion

        #region 克隆、复制
        public override object Clone()
        {
            SceneButtonNode node = base.Clone() as SceneButtonNode;
            node.ReadAddressId = new Dictionary<string, KNXSelectedAddress>();
            foreach (var item in this.ReadAddressId)
            {
                node.ReadAddressId.Add(item.Key, item.Value);
            }
            node.WriteAddressIds = new Dictionary<string, KNXSelectedAddress>();
            foreach (var item in this.WriteAddressIds)
            {
                node.WriteAddressIds.Add(item.Key, item.Value);
            }

            node.ImageOn = this.ImageOn;
            node.ColorOn = this.ColorOn;
            node.ImageOff = this.ImageOff;
            node.ColorOff = this.ColorOff;
            node.IsGroup = this.IsGroup;
            node.DefaultValue = this.DefaultValue;

            return node;
        }

        public override object Copy()
        {
            SceneButtonNode node = base.Copy() as SceneButtonNode;
            node.SetText(node.Title);
            return node;
        }
        #endregion

        #region 覆写方法
        public override void SetText(string title)
        {
            base.SetText(UIResMang.GetString("TextSceneButton"));
        }

        public override string GetText(string text)
        {
            return base.GetText(UIResMang.GetString("TextSceneButton"));
        }

        public override void DrawAt(Graphics g, float ratio, bool preview)
        {
            base.DrawAt(g, ratio, preview);

            Rectangle rect = new Rectangle(Point.Empty, this.RectInPage.Size);
            if (ControlState.Move == this.State)
            {
                Pen pen = new Pen(Color.Navy, 2.0f);
                DrawRoundRectangle(g, pen, this.RectInPage, this.Radius, 1.0f, ratio);
            }
            else
            {
                Bitmap bm = new Bitmap(this.RectInPage.Width, this.RectInPage.Height);
                Graphics gp = Graphics.FromImage(bm);

                Color backColor = Color.White;
                if (null != this.ColorOn)
                {
                    backColor = Color.FromArgb((int)(this.Alpha * 255), this.ColorOn);
                }
                else if (null != this.ColorOff)
                {
                    backColor = Color.FromArgb((int)(this.Alpha * 255), this.ColorOff);
                }
                else
                {
                    backColor = Color.FromArgb((int)(this.Alpha * 255), this.BackgroundColor);
                }

                if (EFlatStyle.Stereo == this.FlatStyle)
                {
                    /* 绘制立体效果，三色渐变 */
                    LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                    Color[] colors = new Color[3];
                    colors[0] = ColorHelper.changeBrightnessOfColor(backColor, 100);
                    colors[1] = backColor;
                    colors[2] = ColorHelper.changeBrightnessOfColor(backColor, -50);
                    ColorBlend blend = new ColorBlend();
                    blend.Positions = new float[] { 0.0f, 0.3f, 1.0f };
                    blend.Colors = colors;
                    brush.InterpolationColors = blend;
                    FillRoundRectangle(gp, brush, rect, this.Radius, 1.0f, ratio);
                    brush.Dispose();
                }
                else if (EFlatStyle.Flat == this.FlatStyle)
                {
                    SolidBrush brush = new SolidBrush(backColor);
                    FillRoundRectangle(gp, brush, rect, this.Radius, 1.0f, ratio);
                }

                int p = (int)Math.Round(PADDING * ratio, 0);

                /* 图标 */
                int x = p;
                int y = p;  // 到父视图顶部的距离
                int width = 0;
                int height = 0;
                Image img = (null != this.ImgImageOn) ? this.ImgImageOn : this.ImgImageOff;
                if (null != img)
                {
                    height = rect.Height - 2 * y;
                    width = height;
                    gp.DrawImage(ImageHelper.Resize(img, new Size(width, height), false), rect.X + x, rect.Y + y);
                }

                /* 文本 */
                if (null != this.Title)
                {
                    if (null != img)
                    {
                        x += width + p/*PADDING*/;
                        width = rect.Width - x - p/*PADDING*/;
                        height = rect.Height - 2 * y;
                    }
                    else
                    {
                        width = rect.Width - 2 * x;
                        height = rect.Height - 2 * y;
                    }

                    Rectangle stateRect = new Rectangle(rect.X + x, rect.Y + y, width, height);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    Color fontColor = this.TitleFont.Color;
                    Font font = this.TitleFont.GetFont(ratio);
                    gp.DrawString(this.Title, font, new SolidBrush(fontColor), stateRect, sf);
                }

                if (EBool.Yes == this.DisplayBorder)
                {
                    Color borderColor = this.BorderColor;
                    DrawRoundRectangle(gp, new Pen(borderColor, 1), rect, this.Radius, 1.0f, ratio);
                }

                g.DrawImage(bm,
                    this.VisibleRectInPage,
                    new Rectangle(new Point(this.VisibleRectInPage.X - this.RectInPage.X, this.VisibleRectInPage.Y - this.RectInPage.Y), this.VisibleRectInPage.Size),
                    GraphicsUnit.Pixel);

                if (!preview)
                {
                    this.FrameIsVisible = false;
                    if (this.IsThisSelected)
                    {
                        this.SetFrame();
                        Pen pen = new Pen(Color.LightGray, 1.0f);
                        pen.DashStyle = DashStyle.Dot;//设置为虚线,用虚线画四边，模拟微软效果
                        g.DrawLine(pen, this.LinePoints[0], this.LinePoints[1]);
                        g.DrawLine(pen, this.LinePoints[2], this.LinePoints[3]);
                        g.DrawLine(pen, this.LinePoints[4], this.LinePoints[5]);
                        g.DrawLine(pen, this.LinePoints[6], this.LinePoints[7]);
                        g.DrawLine(pen, this.LinePoints[8], this.LinePoints[9]);
                        g.DrawLine(pen, this.LinePoints[10], this.LinePoints[11]);
                        g.DrawLine(pen, this.LinePoints[12], this.LinePoints[13]);
                        g.DrawLine(pen, this.LinePoints[14], this.LinePoints[15]);

                        g.FillRectangles(Brushes.White, this.SmallRects); //填充8个小矩形的内部
                        g.DrawRectangles(Pens.Black, this.SmallRects);  //绘制8个小矩形的黑色边线

                        this.FrameIsVisible = true;
                    }
                }
            }
        }
        #endregion

        #region 转为KNX
        public KNXSceneButton ToKnx(BackgroundWorker worker)
        {
            var knx = new KNXSceneButton();

            base.ToKnx(knx, worker);

            knx.ReadAddressId = this.ReadAddressId;
            knx.WriteAddressIds = this.WriteAddressIds;

            //ImageHelper.SaveImageAsPNG(this.ImageOn, Path.Combine(this.ImagePath, NAME_IMAGEON));
            knx.ImageOn = this.ImageOn;
            knx.ColorOn = ColorHelper.ColorToHexStr(this.ColorOn);
            //ImageHelper.SaveImageAsPNG(this.ImageOff, Path.Combine(this.ImagePath, NAME_IMAGEOFF));
            knx.ImageOff = this.ImageOff;
            knx.ColorOff = ColorHelper.ColorToHexStr(this.ColorOff);
            knx.IsGroup = (int)this.IsGroup;
            knx.DefaultValue = this.DefaultValue - 1;

            //foreach (string file in Directory.GetFiles(this.ImagePath))
            //{
            //    string fileName = file.Substring(file.LastIndexOf("\\") + 1);
            //    if ((fileName == NAME_IMAGEON)
            //        || (fileName == NAME_IMAGEOFF))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        File.Delete(file);
            //    }
            //}

            MyCache.ValidResImgNames.Add(knx.ImageOn);
            MyCache.ValidResImgNames.Add(knx.ImageOff);

            return knx;
        }

        public KNXSceneButton ExportTo(BackgroundWorker worker, string dir, Point RelPoint)
        {
            KNXSceneButton knx = this.ToKnx(worker);
            //knx.Left -= RelPoint.X;
            //knx.Top -= RelPoint.Y;
            knx.Left = this.LocationInPageFact.X - RelPoint.X;
            knx.Top = this.LocationInPageFact.Y - RelPoint.Y;

            knx.ReadAddressId.Clear();
            knx.WriteAddressIds.Clear();

            knx.ImageOn = FileHelper.CopyFileSole(Path.Combine(MyCache.ProjImgPath, this.ImageOn), dir);
            knx.ImageOff = FileHelper.CopyFileSole(Path.Combine(MyCache.ProjImgPath, this.ImageOff), dir);
            //FileHelper.CopyFolder(this.ImagePath, dir, true);

            return knx;
        }
        #endregion

        #region 属性框显示
        private class PropertyConverter : ExpandableObjectConverter
        {
            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
            {
                PropertyDescriptorCollection collection = TypeDescriptor.GetProperties(value, true);

                List<PropertyDescriptor> list = new List<PropertyDescriptor>();

                STControlPropertyDescriptor propTitle = new STControlPropertyDescriptor(collection["Title"]);
                propTitle.SetCategory(UIResMang.GetString("CategoryTitle"));
                propTitle.SetDisplayName(UIResMang.GetString("PropTitle"));
                list.Add(propTitle);

                STControlPropertyDescriptor PropLocation = new STControlPropertyDescriptor(collection["Location"]);
                PropLocation.SetCategory(UIResMang.GetString("CategoryLayout"));
                PropLocation.SetDisplayName(UIResMang.GetString("PropLocation"));
                PropLocation.SetDescription(UIResMang.GetString(""));
                list.Add(PropLocation);

                STControlPropertyDescriptor PropSize = new STControlPropertyDescriptor(collection["Size"]);
                PropSize.SetCategory(UIResMang.GetString("CategoryLayout"));
                PropSize.SetDisplayName(UIResMang.GetString("PropSize"));
                PropSize.SetDescription(UIResMang.GetString(""));
                list.Add(PropSize);

                STControlPropertyDescriptor PropBorderWidth = new STControlPropertyDescriptor(collection["DisplayBorder"]);
                PropBorderWidth.SetCategory(UIResMang.GetString("CategoryBorder"));
                PropBorderWidth.SetDisplayName(UIResMang.GetString("PropDisplayBorder"));
                list.Add(PropBorderWidth);

                STControlPropertyDescriptor PropBorderColor = new STControlPropertyDescriptor(collection["BorderColor"]);
                PropBorderColor.SetCategory(UIResMang.GetString("CategoryBorder"));
                PropBorderColor.SetDisplayName(UIResMang.GetString("PropBorderColor"));
                list.Add(PropBorderColor);

                STControlPropertyDescriptor PropAlpha = new STControlPropertyDescriptor(collection["Alpha"]);
                PropAlpha.SetCategory(UIResMang.GetString("CategoryAppearance"));
                PropAlpha.SetDisplayName(UIResMang.GetString("PropAlpha"));
                PropAlpha.SetDescription(UIResMang.GetString("DescriptionForPropAlpha"));
                list.Add(PropAlpha);

                STControlPropertyDescriptor PropRadius = new STControlPropertyDescriptor(collection["Radius"]);
                PropRadius.SetCategory(UIResMang.GetString("CategoryAppearance"));
                PropRadius.SetDisplayName(UIResMang.GetString("PropRadius"));
                PropRadius.SetDescription(UIResMang.GetString("DescriptionForPropRadius"));
                list.Add(PropRadius);

                STControlPropertyDescriptor PropFlatStyle = new STControlPropertyDescriptor(collection["FlatStyle"]);
                PropFlatStyle.SetCategory(UIResMang.GetString("CategoryAppearance"));
                PropFlatStyle.SetDisplayName(UIResMang.GetString("PropFlatStyle"));
                PropFlatStyle.SetDescription(UIResMang.GetString("DescriptionForPropFlatStyle"));
                list.Add(PropFlatStyle);

                STControlPropertyDescriptor PropTitleFont = new STControlPropertyDescriptor(collection["TitleFont"]);
                PropTitleFont.SetCategory(UIResMang.GetString("CategoryTitle"));
                PropTitleFont.SetDisplayName(UIResMang.GetString("PropTitleFont"));
                list.Add(PropTitleFont);

                STControlPropertyDescriptor PropEtsWriteAddressIds = new STControlPropertyDescriptor(collection["WriteAddressIds"]);
                PropEtsWriteAddressIds.SetCategory(UIResMang.GetString("CategoryGroupAddress"));
                PropEtsWriteAddressIds.SetDisplayName(UIResMang.GetString("PropEtsWriteAddressIds"));
                list.Add(PropEtsWriteAddressIds);

                STControlPropertyDescriptor PropEtsReadAddressId = new STControlPropertyDescriptor(collection["ReadAddressId"]);
                PropEtsReadAddressId.SetCategory(UIResMang.GetString("CategoryGroupAddress"));
                PropEtsReadAddressId.SetDisplayName(UIResMang.GetString("PropEtsReadAddressId"));
                list.Add(PropEtsReadAddressId);

                STControlPropertyDescriptor PropHasTip = new STControlPropertyDescriptor(collection["HasTip"]);
                PropHasTip.SetCategory(UIResMang.GetString("CategoryOperation"));
                PropHasTip.SetDisplayName(UIResMang.GetString("PropHasTip"));
                PropHasTip.SetDescription(UIResMang.GetString("DescriptionForPropHasTip"));
                list.Add(PropHasTip);

                STControlPropertyDescriptor PropTip = new STControlPropertyDescriptor(collection["Tip"]);
                PropTip.SetCategory(UIResMang.GetString("CategoryOperation"));
                PropTip.SetDisplayName(UIResMang.GetString("PropTip"));
                PropTip.SetDescription(UIResMang.GetString("DescriptionForPropTip"));
                list.Add(PropTip);

                STControlPropertyDescriptor PropClickable = new STControlPropertyDescriptor(collection["Clickable"]);
                PropClickable.SetCategory(UIResMang.GetString("CategoryOperation"));
                PropClickable.SetDisplayName(UIResMang.GetString("PropClickable"));
                PropClickable.SetDescription(UIResMang.GetString("DescriptionForPropClickable"));
                list.Add(PropClickable);

                STControlPropertyDescriptor PropSwitchImageOn = new STControlPropertyDescriptor(collection["ImageOn"]);
                PropSwitchImageOn.SetCategory(UIResMang.GetString("CategoryDisplay"));
                PropSwitchImageOn.SetDisplayName(UIResMang.GetString("PropSwitchImageOn"));
                PropSwitchImageOn.SetDescription(UIResMang.GetString("DescriptionForPropImageOn"));
                list.Add(PropSwitchImageOn);

                STControlPropertyDescriptor PropColorOn = new STControlPropertyDescriptor(collection["ColorOn"]);
                PropColorOn.SetCategory(UIResMang.GetString("CategoryDisplay"));
                PropColorOn.SetDisplayName(UIResMang.GetString("PropColorOn"));
                PropColorOn.SetDescription(UIResMang.GetString("DescriptionForPropColorOn"));
                list.Add(PropColorOn);

                STControlPropertyDescriptor PropSwitchImageOff = new STControlPropertyDescriptor(collection["ImageOff"]);
                PropSwitchImageOff.SetCategory(UIResMang.GetString("CategoryDisplay"));
                PropSwitchImageOff.SetDisplayName(UIResMang.GetString("PropSwitchImageOff"));
                PropSwitchImageOff.SetDescription(UIResMang.GetString("DescriptionForPropImageOff"));
                list.Add(PropSwitchImageOff);

                STControlPropertyDescriptor PropColorOff = new STControlPropertyDescriptor(collection["ColorOff"]);
                PropColorOff.SetCategory(UIResMang.GetString("CategoryDisplay"));
                PropColorOff.SetDisplayName(UIResMang.GetString("PropColorOff"));
                PropColorOff.SetDescription(UIResMang.GetString("DescriptionForPropColorOff"));
                list.Add(PropColorOff);

                STControlPropertyDescriptor PropIsGroup = new STControlPropertyDescriptor(collection["IsGroup"]);
                PropIsGroup.SetCategory(UIResMang.GetString("CategoryGroupBox"));
                PropIsGroup.SetDisplayName(UIResMang.GetString("PropIsGroup"));
                PropIsGroup.SetDescription(UIResMang.GetString("DescriptionForPropIsGroup"));
                list.Add(PropIsGroup);

                STControlPropertyDescriptor PropDefaultValue = new STControlPropertyDescriptor(collection["DefaultValue"]);
                PropDefaultValue.SetCategory(UIResMang.GetString("CategoryGroupBox"));
                PropDefaultValue.SetDisplayName(UIResMang.GetString("PropDefaultValue"));
                PropDefaultValue.SetDescription(UIResMang.GetString("DescriptionForPropDefaultValue"));
                list.Add(PropDefaultValue);

                return new PropertyDescriptorCollection(list.ToArray());
            }
        }
        #endregion
    }
}
