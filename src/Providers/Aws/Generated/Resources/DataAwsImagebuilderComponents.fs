namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderComponentsState = { assignments: ResizeArray<aws.DataAwsImagebuilderComponents.DataAwsImagebuilderComponentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_components">aws_imagebuilder_components</a>.
    /// </summary>
    type DataAwsImagebuilderComponentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderComponentsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderComponentsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_components#filter-1">DataAwsImagebuilderComponents#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderComponents.DataAwsImagebuilderComponentsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderComponentsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderComponentsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderComponentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_components#id-1">DataAwsImagebuilderComponents#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderComponentsState, value: string) : DataAwsImagebuilderComponentsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderComponentsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_components#owner-1">DataAwsImagebuilderComponents#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: DataAwsImagebuilderComponentsState, value: string) : DataAwsImagebuilderComponentsState =
            state.assignments.Add(fun config -> config.Owner <- value)
            state : DataAwsImagebuilderComponentsState

        member _.Run(state: DataAwsImagebuilderComponentsState) : aws.DataAwsImagebuilderComponents.DataAwsImagebuilderComponents =
            let config = aws.DataAwsImagebuilderComponents.DataAwsImagebuilderComponentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderComponents.DataAwsImagebuilderComponents(StackContext.get (), logicalId, config)
