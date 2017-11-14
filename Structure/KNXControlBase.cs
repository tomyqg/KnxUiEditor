using System.Collections.Generic;

namespace Structure
{
    /// <summary>
    /// �ؼ�������
    /// </summary>
    public class KNXControlBase : KNXView
    {
        ///// <summary>
        ///// ����ַ
        ///// </summary>
        //public Dictionary<string, KNXSelectedAddress> ReadAddressId { get; set; }

        ///// <summary>
        ///// д��ַ�б�
        ///// </summary>
        //public Dictionary<string, KNXSelectedAddress> WriteAddressIds { get; set; }

        public int HasTip { get; set; }

        public string Tip { get; set; }

        /// <summary>
        /// �ؼ��Ƿ�ɵ��
        /// </summary>
        public int Clickable { get; set; }

        /// <summary>
        /// �û��Զ���Ŀؼ�ͼ��ͼ�ꡣ
        /// ������ 2.1.1
        /// </summary>
        public string Icon { get; set; }
    }
}