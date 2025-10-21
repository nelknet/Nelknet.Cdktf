namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbInstanceState = { assignments: ResizeArray<aws.DataAwsDbInstance.DataAwsDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instance">aws_db_instance</a>.
    /// </summary>
    type DataAwsDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDbInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instance#db_instance_identifier-1">DataAwsDbInstance#db_instance_identifier</a>.
        /// </summary>
        [<CustomOperation "db_instance_identifier">]
        member _.DbInstanceIdentifier(state: DataAwsDbInstanceState, value: string) : DataAwsDbInstanceState =
            state.assignments.Add(fun config -> config.DbInstanceIdentifier <- value)
            state : DataAwsDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instance#id-1">DataAwsDbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbInstanceState, value: string) : DataAwsDbInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instance#tags-1">DataAwsDbInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDbInstanceState, value: seq<string * string>) : DataAwsDbInstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDbInstanceState

        member _.Run(state: DataAwsDbInstanceState) : aws.DataAwsDbInstance.DataAwsDbInstance =
            let config = aws.DataAwsDbInstance.DataAwsDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbInstance.DataAwsDbInstance(StackContext.get (), logicalId, config)
