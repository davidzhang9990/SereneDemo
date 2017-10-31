using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace BowenSerene.Default
{
    public partial class PurchaseOrderDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "BowenSerene.Default.PurchaseOrderDetailEditor";

        public PurchaseOrderDetailEditorAttribute()
            : base(Key)
        {
        }

        public String AssignDate
        {
            get { return GetOption<String>("AssignDate"); }
            set { SetOption("AssignDate", value); }
        }

        public String AssignOrderDate
        {
            get { return GetOption<String>("AssignOrderDate"); }
            set { SetOption("AssignOrderDate", value); }
        }

        public Double AutoHeight
        {
            get { return GetOption<Double>("AutoHeight"); }
            set { SetOption("AutoHeight", value); }
        }

        public Double AutoLength
        {
            get { return GetOption<Double>("AutoLength"); }
            set { SetOption("AutoLength", value); }
        }

        public Double AutoQuantity
        {
            get { return GetOption<Double>("AutoQuantity"); }
            set { SetOption("AutoQuantity", value); }
        }

        public Double AutoSize
        {
            get { return GetOption<Double>("AutoSize"); }
            set { SetOption("AutoSize", value); }
        }

        public Double AutoVolume
        {
            get { return GetOption<Double>("AutoVolume"); }
            set { SetOption("AutoVolume", value); }
        }

        public Double AutoWeight
        {
            get { return GetOption<Double>("AutoWeight"); }
            set { SetOption("AutoWeight", value); }
        }

        public Double AutoWidth
        {
            get { return GetOption<Double>("AutoWidth"); }
            set { SetOption("AutoWidth", value); }
        }

        public String BlockNumber
        {
            get { return GetOption<String>("BlockNumber"); }
            set { SetOption("BlockNumber", value); }
        }

        public String Category
        {
            get { return GetOption<String>("Category"); }
            set { SetOption("Category", value); }
        }

        public String Container
        {
            get { return GetOption<String>("Container"); }
            set { SetOption("Container", value); }
        }

        public String Grade
        {
            get { return GetOption<String>("Grade"); }
            set { SetOption("Grade", value); }
        }

        public Double Height
        {
            get { return GetOption<Double>("Height"); }
            set { SetOption("Height", value); }
        }

        public String InsertDate
        {
            get { return GetOption<String>("InsertDate"); }
            set { SetOption("InsertDate", value); }
        }

        public Double InsertUserId
        {
            get { return GetOption<Double>("InsertUserId"); }
            set { SetOption("InsertUserId", value); }
        }

        public Double IsAssign
        {
            get { return GetOption<Double>("IsAssign"); }
            set { SetOption("IsAssign", value); }
        }

        public Double IsAssignOrder
        {
            get { return GetOption<Double>("IsAssignOrder"); }
            set { SetOption("IsAssignOrder", value); }
        }

        public Double IsFinishType
        {
            get { return GetOption<Double>("IsFinishType"); }
            set { SetOption("IsFinishType", value); }
        }

        public Double IsStock
        {
            get { return GetOption<Double>("IsStock"); }
            set { SetOption("IsStock", value); }
        }

        public Double Length
        {
            get { return GetOption<Double>("Length"); }
            set { SetOption("Length", value); }
        }

        public String Mine
        {
            get { return GetOption<String>("Mine"); }
            set { SetOption("Mine", value); }
        }

        public String Notes
        {
            get { return GetOption<String>("Notes"); }
            set { SetOption("Notes", value); }
        }

        public Double OrderDetailId
        {
            get { return GetOption<Double>("OrderDetailId"); }
            set { SetOption("OrderDetailId", value); }
        }

        public String ParentId
        {
            get { return GetOption<String>("ParentId"); }
            set { SetOption("ParentId", value); }
        }

        public String ProductId
        {
            get { return GetOption<String>("ProductId"); }
            set { SetOption("ProductId", value); }
        }

        public Double Quantity
        {
            get { return GetOption<Double>("Quantity"); }
            set { SetOption("Quantity", value); }
        }

        public Double Size
        {
            get { return GetOption<Double>("Size"); }
            set { SetOption("Size", value); }
        }

        public Double SortCode
        {
            get { return GetOption<Double>("SortCode"); }
            set { SetOption("SortCode", value); }
        }

        public String StockDate
        {
            get { return GetOption<String>("StockDate"); }
            set { SetOption("StockDate", value); }
        }

        public Double Thick
        {
            get { return GetOption<Double>("Thick"); }
            set { SetOption("Thick", value); }
        }

        public String UpdateDate
        {
            get { return GetOption<String>("UpdateDate"); }
            set { SetOption("UpdateDate", value); }
        }

        public Double UpdateUserId
        {
            get { return GetOption<Double>("UpdateUserId"); }
            set { SetOption("UpdateUserId", value); }
        }

        public Double Volume
        {
            get { return GetOption<Double>("Volume"); }
            set { SetOption("Volume", value); }
        }

        public Double Weight
        {
            get { return GetOption<Double>("Weight"); }
            set { SetOption("Weight", value); }
        }

        public Double Width
        {
            get { return GetOption<Double>("Width"); }
            set { SetOption("Width", value); }
        }
    }
}

