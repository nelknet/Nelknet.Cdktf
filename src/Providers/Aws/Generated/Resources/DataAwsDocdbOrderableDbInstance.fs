namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDocdbOrderableDbInstanceState = { assignments: ResizeArray<aws.DataAwsDocdbOrderableDbInstance.DataAwsDocdbOrderableDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance">aws_docdb_orderable_db_instance</a>.
    /// </summary>
    type DataAwsDocdbOrderableDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDocdbOrderableDbInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDocdbOrderableDbInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#engine-1">DataAwsDocdbOrderableDbInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsDocdbOrderableDbInstanceState, value: string) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#engine_version-1">DataAwsDocdbOrderableDbInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DataAwsDocdbOrderableDbInstanceState, value: string) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#id-1">DataAwsDocdbOrderableDbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDocdbOrderableDbInstanceState, value: string) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#instance_class-1">DataAwsDocdbOrderableDbInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: DataAwsDocdbOrderableDbInstanceState, value: string) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#license_model-1">DataAwsDocdbOrderableDbInstance#license_model</a>.
        /// </summary>
        [<CustomOperation "license_model">]
        member _.LicenseModel(state: DataAwsDocdbOrderableDbInstanceState, value: string) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.LicenseModel <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#preferred_instance_classes-1">DataAwsDocdbOrderableDbInstance#preferred_instance_classes</a>.
        /// </summary>
        [<CustomOperation "preferred_instance_classes">]
        member _.PreferredInstanceClasses(state: DataAwsDocdbOrderableDbInstanceState, value: seq<string>) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.PreferredInstanceClasses <- (value |> Seq.toArray))
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#vpc-1">DataAwsDocdbOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsDocdbOrderableDbInstanceState, value: bool) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_orderable_db_instance#vpc-1">DataAwsDocdbOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsDocdbOrderableDbInstanceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDocdbOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsDocdbOrderableDbInstanceState

        member _.Run(state: DataAwsDocdbOrderableDbInstanceState) : aws.DataAwsDocdbOrderableDbInstance.DataAwsDocdbOrderableDbInstance =
            let config = aws.DataAwsDocdbOrderableDbInstance.DataAwsDocdbOrderableDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDocdbOrderableDbInstance.DataAwsDocdbOrderableDbInstance(StackContext.get (), logicalId, config)
