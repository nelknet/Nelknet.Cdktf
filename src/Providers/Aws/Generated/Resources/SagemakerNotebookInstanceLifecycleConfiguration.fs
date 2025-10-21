namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerNotebookInstanceLifecycleConfigurationState = { assignments: ResizeArray<aws.SagemakerNotebookInstanceLifecycleConfiguration.SagemakerNotebookInstanceLifecycleConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration">aws_sagemaker_notebook_instance_lifecycle_configuration</a>.
    /// </summary>
    type SagemakerNotebookInstanceLifecycleConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerNotebookInstanceLifecycleConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SagemakerNotebookInstanceLifecycleConfigurationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#id-1">SagemakerNotebookInstanceLifecycleConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: string) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#name-1">SagemakerNotebookInstanceLifecycleConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: string) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#on_create-1">SagemakerNotebookInstanceLifecycleConfiguration#on_create</a>.
        /// </summary>
        [<CustomOperation "on_create">]
        member _.OnCreate(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: string) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.OnCreate <- value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#on_start-1">SagemakerNotebookInstanceLifecycleConfiguration#on_start</a>.
        /// </summary>
        [<CustomOperation "on_start">]
        member _.OnStart(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: string) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.OnStart <- value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#tags-1">SagemakerNotebookInstanceLifecycleConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: seq<string * string>) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance_lifecycle_configuration#tags_all-1">SagemakerNotebookInstanceLifecycleConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerNotebookInstanceLifecycleConfigurationState, value: seq<string * string>) : SagemakerNotebookInstanceLifecycleConfigurationState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerNotebookInstanceLifecycleConfigurationState

        member _.Run(state: SagemakerNotebookInstanceLifecycleConfigurationState) : aws.SagemakerNotebookInstanceLifecycleConfiguration.SagemakerNotebookInstanceLifecycleConfiguration =
            let config = aws.SagemakerNotebookInstanceLifecycleConfiguration.SagemakerNotebookInstanceLifecycleConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerNotebookInstanceLifecycleConfiguration.SagemakerNotebookInstanceLifecycleConfiguration(StackContext.get (), logicalId, config)
