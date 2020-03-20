using NetModular.Lib.Data.Abstractions.Attributes;

namespace NetModular.Module.Forum.Domain.Comment
{
    public partial class CommentEntity
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

        #region To 
        /// <summary>
        /// �ǳ�
        /// </summary>
        [Ignore] public string ToNickName { get; set; }

        /// <summary>
        /// �Ա�
        /// </summary>
        [Ignore] public int ToSex { get; set; }

        /// <summary>
        /// ͷ��
        /// </summary>
        [Ignore] public string ToAvatar { get; set; }

        #endregion 
    }
}
