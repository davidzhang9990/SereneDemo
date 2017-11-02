namespace BowenSerene.Default {
    export class TemplateDownDialogForm extends Serenity.PrefixedContext {
        static formKey = 'Default.TemplateDown';

    }

    export interface TemplateDownDialogForm {
        SupplierId: Serenity.LookupEditor;
    }

    [['SupplierId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(TemplateDownDialogForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

