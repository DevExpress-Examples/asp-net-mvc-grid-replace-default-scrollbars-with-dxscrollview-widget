<!-- default file list -->
*Files to look at*:

* [scripts.js](./CS/GridViewWithDxScrollView/Scripts/scripts.js) (VB: [scripts.js](./VB/GridViewWithDxScrollView/Scripts/scripts.js))
* [_GridViewPartial.cshtml](./CS/GridViewWithDxScrollView/Views/Home/_GridViewPartial.cshtml)
* **[Index.cshtml](./CS/GridViewWithDxScrollView/Views/Home/Index.cshtml)**
* [_Layout.cshtml](./CS/GridViewWithDxScrollView/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# GridView - How to use the dxScrollView widget instead of default browser scrollbars
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t532374/)**
<!-- run online end -->


<p>This example demonstrates how to use the dxScrollView HTML5/JS widget to substitute the default browser scrollbars. To be able to apply the dxScrollView widget to GridView's scrollable element, enable vertical and horizontal scrolling by setting the GridViewSettings.Settings.<a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridSettings.HorizontalScrollBarMode.property">HorizontalScrollBarMode</a> and GridViewSettings.Settings.<a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridSettings.VerticalScrollBarMode.property">VerticalScrollBarMode</a> properties to <a href="https://documentation.devexpress.com/AspNet/DevExpressWebScrollBarModeEnumtopic.aspx">ScrollBarMode</a>.Auto. Make sure that you also specify the GridViewSettings.Settings.<a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridSettings.VerticalScrollableHeight.property">VerticalScrollableHeight</a> property to see a vertical scrollbar.<br><br>The dxScrollView widget should be applied to the GridView extension on the first load of the grid and after each callback. Apply the dxScrollWidget to the 'dxgvCSD' element:</p>


```js
GetScrollableElement().dxScrollView({
    showScrollbar: 'always',
    direction: 'both',
    scrollByContent: IsScrollByContent.GetChecked(),
    showScrollbar: ShowScrollBar.GetValue(),
    onScroll: function (e) {
        $('.dxgvHSDC .dxgvTable_DevEx').css('transform', 'translateX(' + (-e.scrollOffset.left) + 'px)');
    }
});
```


<p>Note that you need to move the header element using the code from the onScroll method.</p>

<br/>


