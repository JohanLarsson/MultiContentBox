using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MultiContentBox
{
    [ContentProperty("MultiContent")]
    public class MultiContentControl : Control
    {
        public static readonly DependencyProperty DataTemplateProperty = DependencyProperty.Register(
            "DataTemplate", typeof(DataTemplate), typeof(MultiContentControl), new PropertyMetadata(default(DataTemplate)));

        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(
            "Content", typeof(object), typeof(MultiContentControl), new PropertyMetadata(default(object)));

        private readonly MultiContent _multiContent;

        public MultiContentControl()
        {
            _multiContent = new MultiContent(this);
        }

        public IList MultiContent
        {
            get { return _multiContent; }
        }

        public DataTemplate DataTemplate
        {
            get { return (DataTemplate)GetValue(DataTemplateProperty); }
            set { SetValue(DataTemplateProperty, value); }
        }

        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
    }
}
