namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNeptuneOrderableDbInstanceState = { assignments: ResizeArray<aws.DataAwsNeptuneOrderableDbInstance.DataAwsNeptuneOrderableDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance">aws_neptune_orderable_db_instance</a>.
    /// </summary>
    type DataAwsNeptuneOrderableDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNeptuneOrderableDbInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNeptuneOrderableDbInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#engine-1">DataAwsNeptuneOrderableDbInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsNeptuneOrderableDbInstanceState, value: string) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#engine_version-1">DataAwsNeptuneOrderableDbInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DataAwsNeptuneOrderableDbInstanceState, value: string) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#id-1">DataAwsNeptuneOrderableDbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNeptuneOrderableDbInstanceState, value: string) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#instance_class-1">DataAwsNeptuneOrderableDbInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: DataAwsNeptuneOrderableDbInstanceState, value: string) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#license_model-1">DataAwsNeptuneOrderableDbInstance#license_model</a>.
        /// </summary>
        [<CustomOperation "license_model">]
        member _.LicenseModel(state: DataAwsNeptuneOrderableDbInstanceState, value: string) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.LicenseModel <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#preferred_instance_classes-1">DataAwsNeptuneOrderableDbInstance#preferred_instance_classes</a>.
        /// </summary>
        [<CustomOperation "preferred_instance_classes">]
        member _.PreferredInstanceClasses(state: DataAwsNeptuneOrderableDbInstanceState, value: seq<string>) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.PreferredInstanceClasses <- (value |> Seq.toArray))
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#vpc-1">DataAwsNeptuneOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsNeptuneOrderableDbInstanceState, value: bool) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_orderable_db_instance#vpc-1">DataAwsNeptuneOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsNeptuneOrderableDbInstanceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNeptuneOrderableDbInstanceState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsNeptuneOrderableDbInstanceState

        member _.Run(state: DataAwsNeptuneOrderableDbInstanceState) : aws.DataAwsNeptuneOrderableDbInstance.DataAwsNeptuneOrderableDbInstance =
            let config = aws.DataAwsNeptuneOrderableDbInstance.DataAwsNeptuneOrderableDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNeptuneOrderableDbInstance.DataAwsNeptuneOrderableDbInstance(StackContext.get (), logicalId, config)
