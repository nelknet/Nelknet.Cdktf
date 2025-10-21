namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderWorkflowState<'Name, 'Type, 'Version> = { assignments: ResizeArray<aws.ImagebuilderWorkflow.ImagebuilderWorkflowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow">aws_imagebuilder_workflow</a>.
    /// </summary>
    type ImagebuilderWorkflowBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderWorkflowState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderWorkflowState<Missing, Missing, Missing>)

        member _.Zero(()) : ImagebuilderWorkflowState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderWorkflowState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#name-1">ImagebuilderWorkflow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderWorkflowState<Missing, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<Present, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderWorkflowState<Present, 'Type, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#type-1">ImagebuilderWorkflow#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ImagebuilderWorkflowState<'Name, Missing, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, Present, 'Version> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ImagebuilderWorkflowState<'Name, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#version-1">ImagebuilderWorkflow#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ImagebuilderWorkflowState<'Name, 'Type, Missing>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ImagebuilderWorkflowState<'Name, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#change_description-1">ImagebuilderWorkflow#change_description</a>.
        /// </summary>
        [<CustomOperation "change_description">]
        member _.ChangeDescription(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.ChangeDescription <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#data-1">ImagebuilderWorkflow#data</a>.
        /// </summary>
        [<CustomOperation "data">]
        member _.Data(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Data <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#description-1">ImagebuilderWorkflow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#id-1">ImagebuilderWorkflow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#kms_key_id-1">ImagebuilderWorkflow#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#tags-1">ImagebuilderWorkflow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: seq<string * string>) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#tags_all-1">ImagebuilderWorkflow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: seq<string * string>) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_workflow#uri-1">ImagebuilderWorkflow#uri</a>.
        /// </summary>
        [<CustomOperation "uri">]
        member _.Uri(state: ImagebuilderWorkflowState<'Name, 'Type, 'Version>, value: string) : ImagebuilderWorkflowState<'Name, 'Type, 'Version> =
            state.assignments.Add(fun config -> config.Uri <- value)
            state : ImagebuilderWorkflowState<'Name, 'Type, 'Version>

        member _.Run(state: ImagebuilderWorkflowState<Present, Present, Present>) : aws.ImagebuilderWorkflow.ImagebuilderWorkflow =
            let config = aws.ImagebuilderWorkflow.ImagebuilderWorkflowConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderWorkflow.ImagebuilderWorkflow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderWorkflow: missing required arguments. Must call: name, type, version.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderWorkflowState<_, _, _>) : aws.ImagebuilderWorkflow.ImagebuilderWorkflow =
            Unchecked.defaultof<aws.ImagebuilderWorkflow.ImagebuilderWorkflow>
