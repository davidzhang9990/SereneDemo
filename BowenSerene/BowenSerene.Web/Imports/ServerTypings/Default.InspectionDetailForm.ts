namespace BowenSerene.Default {
    export class InspectionDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Default.InspectionDetail';

    }

    export interface InspectionDetailForm {
        ParentId: Serenity.IntegerEditor;
        OrderDetailId: Serenity.IntegerEditor;
    }

    [['ParentId', () => Serenity.IntegerEditor], ['OrderDetailId', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(InspectionDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

