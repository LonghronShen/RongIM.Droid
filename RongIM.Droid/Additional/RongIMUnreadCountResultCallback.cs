using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IO.Rong.Imlib;
using Java.Lang;

namespace RongIM.Droid
{

    public class RongIMUnreadCountResultCallback
        : IO.Rong.Imlib.RongIMUnreadCountResultCallback
    {

        public override void OnError(RongIMClient.ErrorCode p0)
        {
        }

        public override void OnSuccessInt(Integer p0)
        {
        }

    }

}