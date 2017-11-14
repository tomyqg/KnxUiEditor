using System;
using System.ComponentModel;
using System.Drawing;

namespace Structure
{
    public enum ControlType
    {
        Blinds,
        Button
    }

    //��������Ҫ��ʾ�ķ���
    public enum SliderSymbol
    {
        None, DownUp, DardBright, SubtractAdd, Volume
    }

    /// <summary>
    /// ��ý�忪�صİ�ť����
    /// </summary>
    public enum MediaButtonType
    {
        Back = 0,
        Backward = 1,
        Menu = 2,
        Stop = 3,
        BackwardSkip = 4,
        Mute = 5,
        Up = 6,
        Okey = 7,
        VolumeDown = 8,
        Down = 9,
        Pause = 10,
        VolumeUp = 11,
        Forward = 12,
        Play = 13,
        ForwardSkip = 14,
        Power = 15,
        Left = 16,
        Right = 17
    }

    public enum Language
    {
        Chinese,
        English,
        French,
        German,
        Polish,
        Russian,
        Spanish,
        Japanese
    }

    public enum ERegulationStep
    {
        /// <summary>
        /// 0.01
        /// </summary>
        [Description("0.01")]
        PointZeroOne,

        /// <summary>
        /// 0.05
        /// </summary>
        [Description("0.05")]
        PointZeroFive,

        /// <summary>
        /// 0.1
        /// </summary>
        [Description("0.1")]
        PointOne,

        /// <summary>
        /// 0.5
        /// </summary>
        [Description("0.5")]
        PointFive,

        /// <summary>
        /// 1
        /// </summary>
        [Description("1")]
        One,

        /// <summary>
        /// 5
        /// </summary>
        [Description("5")]
        Five,
    }

    public enum EDecimalDigit
    {
        /// <summary>
        /// ��С��
        /// </summary>
        [Description("None")]
        Zero,

        /// <summary>
        /// 1λС��
        /// </summary>
        [Description(".x")]
        One,

        /// <summary>
        /// 2λС��
        /// </summary>
        [Description(".xx")]
        Two
    }

    public enum EMeasurementUnit
    {
        [Description("")]
        None,

        [Description("��")]
        Centigrade,

        //[Description("�H")]
        //Fahrenheit,

        [Description("A")]
        Ampere,

        [Description("mA")]
        Milliampere,

        [Description("KW")]
        Kilowatt
    }

    /// <summary>
    /// �ؼ���ƽ����ʽ
    /// </summary>
    public enum EFlatStyle
    {
        /// <summary>
        /// ��ƽ��
        /// </summary>
        Flat,

        /// <summary>
        /// ���廯
        /// </summary>
        Stereo,
    }

    public enum EBool
    {
        No,

        Yes
    }

    /// <summary>
    /// ����Ԫ�صĻ����࣬�ṩͳһ�Ļ�������
    /// </summary>    
    public class KNXView
    {
        /// <summary>
        /// ����Ԫ�ص�ID������Ӧ��Ψһ
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ����Ԫ����Ҫ��ʾ��ǰ�˵�����
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// �ѱ����á�2.1.1
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// �ؼ�����ʼλ��x
        /// </summary>
        public int Left { get; set; }

        /// <summary>
        /// �ؼ�����ʼλ��y
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// �ؼ��Ŀ��
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// �ؼ��Ŀ��
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// �ؼ����ڱ߾�
        /// ������2.7.1
        /// </summary>
        public KNXPadding Padding { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�߿�
        /// </summary>
        public int DisplayBorder { get; set; }

        /// <summary>
        /// �߿���ɫ
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// �ؼ��Ĳ�͸����
        /// </summary>
        public float Alpha { get; set; }

        /// <summary>
        /// �ؼ���Բ�ǰ뾶
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// �ؼ������
        /// </summary>
        public int FlatStyle { get; set; }

        /// <summary>
        /// �ؼ��ı���ɫ
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// �ؼ��ı���ͼƬ
        /// ������ 2.1.1
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// �ؼ���������ɫ
        /// ������ 2.5.2
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// �����С
        /// ������ 2.5.2
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// ������2.5.2
        /// </summary>
        public KNXFont TitleFont { get; set; }
    }
}
