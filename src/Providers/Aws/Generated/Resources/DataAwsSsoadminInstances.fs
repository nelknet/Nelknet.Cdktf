namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminInstancesState = { assignments: ResizeArray<aws.DataAwsSsoadminInstances.DataAwsSsoadminInstancesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_instances">aws_ssoadmin_instances</a>.
    /// </summary>
    type DataAwsSsoadminInstancesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminInstancesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsoadminInstancesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_instances#id-1">DataAwsSsoadminInstances#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsoadminInstancesState, value: string) : DataAwsSsoadminInstancesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsoadminInstancesState

        member _.Run(state: DataAwsSsoadminInstancesState) : aws.DataAwsSsoadminInstances.DataAwsSsoadminInstances =
            let config = aws.DataAwsSsoadminInstances.DataAwsSsoadminInstancesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminInstances.DataAwsSsoadminInstances(StackContext.get (), logicalId, config)
