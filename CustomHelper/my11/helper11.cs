using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelpers.my11
{
    public static class helper11
    {
        public static MvcHtmlString MyList(this HtmlHelper html, string list)
        {

        return MvcHtmlString.Create( @"<li>" + list + "</li>" );
        }
        public static MvcHtmlString MyImage(this HtmlHelper helper, string src, string altText, string height,string width)
        {

            var builder = new TagBuilder("img");

            builder.MergeAttribute("src", src);

            builder.MergeAttribute("alt", altText);

            builder.MergeAttribute("height", height);

            builder.MergeAttribute("height", width);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));

        }
    }
}