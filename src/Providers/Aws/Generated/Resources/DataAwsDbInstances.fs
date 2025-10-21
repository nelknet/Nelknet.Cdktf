namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbInstancesState = { assignments: ResizeArray<aws.DataAwsDbInstances.DataAwsDbInstancesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instances">aws_db_instances</a>.
    /// </summary>
    type DataAwsDbInstancesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbInstancesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDbInstancesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instances#filter-1">DataAwsDbInstances#filter</a> Accepts: aws.IResolvable | aws.DataAwsDbInstances.DataAwsDbInstancesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsDbInstancesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbInstancesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsDbInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instances#id-1">DataAwsDbInstances#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbInstancesState, value: string) : DataAwsDbInstancesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_instances#tags-1">DataAwsDbInstances#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDbInstancesState, value: seq<string * string>) : DataAwsDbInstancesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDbInstancesState

        member _.Run(state: DataAwsDbInstancesState) : aws.DataAwsDbInstances.DataAwsDbInstances =
            let config = aws.DataAwsDbInstances.DataAwsDbInstancesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbInstances.DataAwsDbInstances(StackContext.get (), logicalId, config)
