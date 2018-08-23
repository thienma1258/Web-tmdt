
class Loading {
    constructor(hidingID,loadingID) {
        this.hidingID = hidingID;
        this.loadingID = loadingID;
    }
    loading() {
        $('#' + this.hidingID).css('display', 'none');
        $('#' + this.loadingID).css('display', 'block');

    }
    finish() {
        $('#' + this.hidingID).css('display', 'block');
        $('#' + this.loadingID).css('display', 'none');
    }
}
var LoadingScript = new Loading('buyForm', 'loadingForm')