namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderComponentState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_component">aws_imagebuilder_component</a>.
    /// </summary>
    type DataAwsImagebuilderComponentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderComponentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderComponentState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderComponentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderComponentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_component#arn-1">DataAwsImagebuilderComponent#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderComponentState<Missing>, value: string) : DataAwsImagebuilderComponentState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderComponentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_component#id-1">DataAwsImagebuilderComponent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderComponentState<'Arn>, value: string) : DataAwsImagebuilderComponentState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderComponentState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_component#tags-1">DataAwsImagebuilderComponent#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderComponentState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderComponentState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderComponentState<'Arn>

        member _.Run(state: DataAwsImagebuilderComponentState<Present>) : aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponent =
            let config = aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderComponent: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderComponentState<_>) : aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponent =
            Unchecked.defaultof<aws.DataAwsImagebuilderComponent.DataAwsImagebuilderComponent>
