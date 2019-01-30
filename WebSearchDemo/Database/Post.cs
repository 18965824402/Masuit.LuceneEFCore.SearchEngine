using Masuit.LuceneEFCore.SearchEngine;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSearchDemo.Database
{
    /// <summary>
    /// ����
    /// </summary>
    [Table("Post")]
    public class Post : LuceneIndexableBaseEntity
    {
        public Post()
        {
            PostDate = DateTime.Now;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���±��ⲻ��Ϊ�գ�"), LuceneIndexable]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required, MaxLength(24, ErrorMessage = "�������֧��24���ַ���"), LuceneIndexable]
        public string Author { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), LuceneIndexable(IsHtml = true)]
        public string Content { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required(ErrorMessage = "�������䲻��Ϊ�գ�"), LuceneIndexable]
        public string Email { get; set; }

        /// <summary>
        /// ��ǩ
        /// </summary>
        [StringLength(256, ErrorMessage = "��ǩ�������255���ַ�"), LuceneIndexable]
        public string Label { get; set; }

        /// <summary>
        /// ���¹ؼ���
        /// </summary>
        [StringLength(256, ErrorMessage = "���¹ؼ����������255���ַ�"), LuceneIndexable]
        public string Keyword { get; set; }

    }
}