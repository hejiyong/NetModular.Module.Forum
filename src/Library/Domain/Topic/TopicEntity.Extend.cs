using NetModular.Lib.Data.Abstractions.Attributes;

namespace NetModular.Module.Forum.Domain.Topic
{
    public partial class TopicEntity
    {
        /// <summary>
        /// �ǳ�
        /// </summary>
        [Ignore] public string NickName { get; set; }

        /// <summary>
        /// �Ա�
        /// </summary>
        [Ignore] public int Sex { get; set; }

        /// <summary>
        /// ͷ��
        /// </summary>
        [Ignore] public string Avatar { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Ignore] public string CategoryName { get; set; }
    }
}
