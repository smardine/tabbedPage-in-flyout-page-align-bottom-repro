When migrating from Xamarin to maui, I remove a deprecated renderer for tabbed page.
Doing so, I have a problem with the flyoutPage which contains a tabbedPage.

Note, the tabbedPage have the android:TabbedPage.ToolbarPlacement="Bottom" attribute

On Xamarin, the detail part of the flyout page fit all screen, horizontally and vertically.
On maui net8.0-android, the detail part does not fit vertically.
it's like he shit up with the tabbar height


|On android, with the flyoutPage as navigation page:|On android, with the flyoutPage as MainPage|
|-|-|
|<img width="359" alt="image" src="https://github.com/dotnet/maui/assets/13467840/3063ea7f-8a88-4c3b-9c43-1985f6564194">|<img width="359" alt="image" src="https://github.com/dotnet/maui/assets/13467840/380c94d8-dda1-41ac-9945-78de917029be">|