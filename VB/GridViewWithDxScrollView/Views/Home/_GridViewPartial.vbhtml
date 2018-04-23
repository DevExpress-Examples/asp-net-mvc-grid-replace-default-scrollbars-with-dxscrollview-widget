@Code
    Dim grid = Html.DevExpress().GridView(Sub(settings)
                                              settings.Name = "GridView"
                                              settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
                                              settings.KeyFieldName = "ID"
                                              settings.Width = 400
                                              settings.Settings.HorizontalScrollBarMode = ScrollBarMode.Auto
                                              settings.Settings.VerticalScrollBarMode = ScrollBarMode.Auto
                                              settings.Settings.VerticalScrollableHeight = 200
                                              settings.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords
                                              settings.SettingsPager.Visible = False
                                              settings.Columns.Add("ID").Width = 200
                                              settings.Columns.Add("Text").Width = 100
                                              settings.Columns.Add("Description").Width = 200
                                              settings.Columns.Add(Sub(col)
                                                                       col.FieldName = "Price"
                                                                       col.PropertiesEdit.DisplayFormatString = "C"
                                                                   End Sub)
                                              settings.ClientSideEvents.Init = "OnGridViewInit"
                                              settings.ClientSideEvents.EndCallback = "OnGridViewEndCallback"
                                          End Sub)
End Code
@grid.Bind(Model).GetHtml()