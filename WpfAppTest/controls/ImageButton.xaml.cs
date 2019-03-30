using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTest.controls
{
    /// <summary>
    /// ImageButton.xaml 的交互逻辑
    /// </summary>
    public partial class ImageButton : Button
    {
        // ------------------------------------------------------------
        //
        // Constructors
        //
        // ------------------------------------------------------------
        #region Constructors

        /// <summary>
        /// Constructor for ImageButton
        /// </summary>
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        #endregion Constructors


        // ------------------------------------------------------------
        //
        // Public Dependancy Properties
        //
        // ------------------------------------------------------------
        #region Public Dependancy Properties


        /// <summary>
        /// Source of the image to use when the ImageButton is in normal state.
        /// </summary>
        public static readonly DependencyProperty SourceProperty = DependencyProperty.RegisterAttached("Source", typeof(ImageSource), typeof(ImageButton));

        public static ImageSource GetSource(DependencyObject obj) => (ImageSource)obj.GetValue(SourceProperty);

        public static void SetSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(SourceProperty, value);
        }


        /// <summary>
        /// Source of the image to use when the ImageButton is in hover state.
        /// </summary>
        public static readonly DependencyProperty HoverSourceProperty = DependencyProperty.RegisterAttached("HoverSource", typeof(ImageSource), typeof(ImageButton));

        public static ImageSource GetHoverSource(DependencyObject obj) => (ImageSource)obj.GetValue(HoverSourceProperty);

        public static void SetHoverSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(HoverSourceProperty, value);
        }


        /// <summary>
        /// Source of the image to use when the ImageButton is in the select state.
        /// </summary>
        public static readonly DependencyProperty SelectedSourceProperty = DependencyProperty.RegisterAttached("SelectedSource", typeof(ImageSource), typeof(ImageButton));

        public static ImageSource GetSelectedSource(DependencyObject obj) => (ImageSource)obj.GetValue(SelectedSourceProperty);

        public static void SetSelectedSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(SelectedSourceProperty, value);
        }

        #endregion Public Dependancy Properties
    }
}
