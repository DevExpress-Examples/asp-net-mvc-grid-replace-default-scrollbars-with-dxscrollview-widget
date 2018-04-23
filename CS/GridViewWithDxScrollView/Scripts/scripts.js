function InitializeScrollView() {
    GetScrollableElement().dxScrollView({
        showScrollbar: 'always',
        direction: 'both',
        scrollByContent: IsScrollByContent.GetChecked(),
        showScrollbar: ShowScrollBar.GetValue(),
        onScroll: function (e) {
            $('.dxgvHSDC .dxgvTable_DevEx').css('transform', 'translateX(' + (-e.scrollOffset.left) + 'px)');
        }
    });
    AdjustHeaderElement();
}

function GetScrollableElement() {
    return $('.dxgvCSD', GridView.GetMainElement());
}
function AdjustHeaderElement() {
    $('.dxgvHSDC')[0].style.paddingRight = '';
    var headerScrollElement = $('.dxgvHSDC > div')[0];
    headerScrollElement.style.width = (GridView.GetMainElement().offsetWidth - 2) + 'px';
}

function OnGridViewInit(s, e) {
    InitializeScrollView();
}

function OnGridViewEndCallback(s, e) {
    InitializeScrollView();
}

function OnScrollByContentCheckedChanged(s, e) {
    GetScrollableElement().dxScrollView('instance').option('scrollByContent', s.GetChecked());
}

function OnScrollbarModeCheckedChanged(s, e) {
    var mode = s.GetValue();
    GetScrollableElement().dxScrollView('instance').option('showScrollbar', mode);
}