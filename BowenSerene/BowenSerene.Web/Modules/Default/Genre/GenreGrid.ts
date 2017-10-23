
namespace BowenSerene.Default {

    @Serenity.Decorators.registerClass()
    export class GenreGrid extends Serenity.EntityGrid<GenreRow, any> {
        protected getColumnsKey() { return 'Default.Genre'; }
        protected getDialogType() { return GenreDialog; }
        protected getIdProperty() { return GenreRow.idProperty; }
        protected getLocalTextPrefix() { return GenreRow.localTextPrefix; }
        protected getService() { return GenreService.baseUrl; }

        protected createSlickGrid(): Slick.Grid {
            let grid = super.createSlickGrid();
            let autoSize = new Slick.AutoColumnSize(true); // *** If you want to make it autoresize when grid is loaded, use: new Slick.AutoColumnSize(true);
            grid.registerPlugin(autoSize);

            return grid;
        }
        constructor(container: JQuery) {
            super(container);

            this.createPDFButton();
        }

        protected createPDFButton() {
            $(".tool-buttons").children("div").children("div").append("<div id='btnPDFGroup' class='btn-group'></div>")

            this.createFirstButton($(".btn-group"), "PDF", "PDFview");

            this.createDropdownList($(".btn-group"), "dropdownlistID", "dropdownMenu");

            this.addDropdownOption($(".dropdownMenu"), "PDFprint", "Print PDF", "printer.png");
            this.addDropdownOption($(".dropdownMenu"), "PDFfile", "Download PDF", "Download.png");

            $("#PDFview").click(e => {
                Common.PdfExportHelper.exportToPdf(
                    {
                        grid: this,
                        onViewSubmit: () => this.onViewSubmit(),
                        output: "newwindow"
                    });
            });

            $("#PDFprint").click(e => {
                Common.PdfExportHelper.exportToPdf(
                    {
                        grid: this,
                        onViewSubmit: () => this.onViewSubmit(),
                        output: "newwindow",
                        autoPrint: true
                    });
            });

            $("#PDFfile").click(e => {
                Common.PdfExportHelper.exportToPdf(
                    {
                        grid: this,
                        onViewSubmit: () => this.onViewSubmit(),
                        output: "file"
                    });
            });
        }

        protected addDropdownOption(element: JQuery, id: string, title: string, image?: string) {
            if (image === undefined)
                element.append("<li id='" + id + "'><a haref='#'><span>" + title + "</span></a></li>");
            else
                element.append("<li id='" + id + "'><a haref='#'><span><img src='..//Content//serenity//images//" + image + "'>" + title + "</span></a></li>");
        }

        protected createDropdownList(element: JQuery, id: string, classUL: string) {
            element.append("<button id='" + id + "' type='button' class='btn btn-sm dropdown-toggle tool-button' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'><span class='caret'></span><span class='sr-only'>Toggle Dropdown</span></button>");
            element.append("<ul class='dropdown-menu " + classUL + "'>");
        }

        protected createFirstButton(element: JQuery, title: string, id: string) {
            element.append("<button type='button' id='" + id + "' class='btn btn-sm tool-button'><span class='button-inner'></span>" + title + "</button>");
        }
    }
}