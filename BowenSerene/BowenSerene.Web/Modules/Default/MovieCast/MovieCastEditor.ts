/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace BowenSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor extends Common.GridEditorBase<MovieCastRow>{

        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;
            row.PersonFullname = PersonRow.getLookup().itemById[row.PersonId].Fullname;
            return true;
        }

        protected getColumnsKey() {
            return "Default.MovieCast";
        }

        protected getLocalTextPrefix() {
            return MovieCastRow.localTextPrefix;
        }

        protected getDialogType() {
            return MovieCastEditDialog;
        }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
    }
}