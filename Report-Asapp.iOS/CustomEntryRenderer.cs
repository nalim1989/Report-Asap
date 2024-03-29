﻿using System;
using CoreGraphics;
using Report_Asapp.iOS;
using ReportAsapp.View.Custom;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Report_Asapp.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
                return;
            Control.BorderStyle = UITextBorderStyle.None;
            UpdateBorderWidth();
            UpdateBorderColor();
            UpdateBorderRadius();
            UpdateLeftPadding();
            UpdateRightPadding();
            Control.ClipsToBounds = true;
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (this.Element == null)
                return;
            if (e.PropertyName == CustomEntry.BorderWidthProperty.PropertyName)
            {
                UpdateBorderWidth();
            }
            else if (e.PropertyName == CustomEntry.BorderColorProperty.PropertyName)
            {
                UpdateBorderColor();
            }
            else if (e.PropertyName == CustomEntry.BorderRadiusProperty.PropertyName)
            {
                UpdateBorderRadius();
            }
            else if (e.PropertyName == CustomEntry.LeftPaddingProperty.PropertyName)
            {
                UpdateLeftPadding();
            }
            else if (e.PropertyName == CustomEntry.RightPaddingProperty.PropertyName)
            {
                UpdateRightPadding();
            }
        }


  

        private void UpdateBorderWidth()
        {
            var entryEx = this.Element as CustomEntry;
            Control.Layer.BorderWidth = entryEx.BorderWidth;
        }

        private void UpdateBorderColor()
        {
            var entryEx = this.Element as CustomEntry;
            Control.Layer.BorderColor = entryEx.BorderColor.ToUIColor().CGColor;
        }

        private void UpdateBorderRadius()
        {
            var entryEx = this.Element as CustomEntry;
            Control.Layer.CornerRadius = (nfloat)entryEx.BorderRadius;
        }

        private void UpdateLeftPadding()
        {
            var entryEx = this.Element as CustomEntry;
            var leftPaddingView = new UIView(new CGRect(0, 0, entryEx.LeftPadding, 0));
            Control.LeftView = leftPaddingView;
            Control.LeftViewMode = UITextFieldViewMode.Always;
        }

        private void UpdateRightPadding()
        {
            var entryEx = this.Element as CustomEntry;
            var rightPaddingView = new UIView(new CGRect(0, 0, entryEx.RightPadding, 0));
            Control.RightView = rightPaddingView;
            Control.RightViewMode = UITextFieldViewMode.Always;
        }

    }
}
