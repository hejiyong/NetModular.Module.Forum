using NetModular.Lib.Data.Abstractions.Attributes;

namespace NetModular.Module.Forum.Domain.TopicTag
{
    public partial class TopicTagEntity
    {
        /// <summary>
        /// �������
        /// </summary>
        [Ignore] public string TopicTitle { get; set; }

        /// <summary>
        /// ��ǩ����
        /// </summary>
        [Ignore] public string TagName { get; set; }

        /// <summary>
        /// �ǳ�
        /// </summary>
        [Ignore] public string NickName { get; set; }

    }
}
