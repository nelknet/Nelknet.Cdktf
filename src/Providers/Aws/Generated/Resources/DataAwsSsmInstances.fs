namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmInstancesState = { assignments: ResizeArray<aws.DataAwsSsmInstances.DataAwsSsmInstancesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_instances">aws_ssm_instances</a>.
    /// </summary>
    type DataAwsSsmInstancesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmInstancesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsmInstancesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_instances#filter-1">DataAwsSsmInstances#filter</a> Accepts: aws.IResolvable | aws.DataAwsSsmInstances.DataAwsSsmInstancesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSsmInstancesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsmInstancesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSsmInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_instances#id-1">DataAwsSsmInstances#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmInstancesState, value: string) : DataAwsSsmInstancesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmInstancesState

        member _.Run(state: DataAwsSsmInstancesState) : aws.DataAwsSsmInstances.DataAwsSsmInstances =
            let config = aws.DataAwsSsmInstances.DataAwsSsmInstancesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmInstances.DataAwsSsmInstances(StackContext.get (), logicalId, config)
