
@Code
    ViewBag.Title = "dxScrollView in GridView"
End Code

<h2>How To use the dxScrollView widget instead Of Default browser scrollbars</h2>
<blockquote cite = "https://isc.devexpress.com/Thread/WorkplaceDetails/T532374" >
    This example demonstrates how To use the dxScrollView HTML5/JS widget To substitute the Default browser scrollbars.
    <br />
    You can change the dxScrollView widget's settings using the "dxScrollView settings" form.
    <ul>
        <li>
            <strong>Scroll by Content.</strong>
            <ul>
                <li>
                    Checked - you can scroll the view by dragging the content area.
                </li>
                <li>
                    Unchecked - scrolling Is possible only by dragging scrollbars.
                </li>
            </ul>
        </li>
        <li>
            <strong>Scrollbar mode.</strong>
            <ul>
                <li>
                    On Scroll - scrollbars will be visible only If you scroll the content area.
                </li>
                <li>
                    On Hover - scrollbars will be visible If you hover the mouse pointer over the content area.
                </li>
                <li>
                    Always - scorllbars will always be visible.
                </li>
                <li>
                    Never - scrollbars are never visible (scrolling Is still possible).
                </li>
            </ul>
        </li>
    </ul>
</blockquote>

@Html.DevExpress().FormLayout(Sub(settings)
	settings.Name = "ScrollViewSettings"
	settings.Items.AddGroupItem(Sub(group)
		group.Name = "SettingsGroup"
		group.Caption = "dxScrollView settings"
		group.Items.Add(Sub(item)
			item.Name = "IsScrollByContent"
			item.Caption = "Scroll by Content"
			item.NestedExtension().CheckBox(Sub(chbSettings)
				chbSettings.Checked = False
				chbSettings.Properties.ClientSideEvents.CheckedChanged = "OnScrollByContentCheckedChanged"
			End Sub)
		End Sub)
		group.Items.Add(Sub(item)
			item.Name = "ShowScrollBar"
			item.Caption = "Scrollbar mode"
			item.NestedExtension().ComboBox(Sub(cbSettings)
				cbSettings.Properties.Items.Add("On Scroll", "onScroll")
				cbSettings.Properties.Items.Add("On Hover", "onHover")
				cbSettings.Properties.Items.Add("Always", "always")
				cbSettings.Properties.Items.Add("Never", "never")
				cbSettings.SelectedIndex = 0
				cbSettings.Properties.ClientSideEvents.SelectedIndexChanged = "OnScrollbarModeCheckedChanged"
			End Sub)
		End Sub)
	End Sub)
End Sub).GetHtml()

@Html.Action("GridViewPartial")
