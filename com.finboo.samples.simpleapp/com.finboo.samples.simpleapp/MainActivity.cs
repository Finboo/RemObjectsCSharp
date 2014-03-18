using java.util;
using android.app;
using android.content;
using android.os;
using android.util;
using android.view;
using android.widget;
using android.support.v4.app;

namespace com.finboo.samples.simpleapp
{
	public class MainActivity: FragmentActivity
	{
		public override void onCreate(Bundle savedInstanceState)
		{
			base.onCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			ContentView = R.layout.main;
		}

    public override void onResume() {
        base.onResume();

    }

	}
}
