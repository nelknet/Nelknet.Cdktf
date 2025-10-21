namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerNotebookInstance.SagemakerNotebookInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance">aws_sagemaker_notebook_instance</a>.
    /// </summary>
    type SagemakerNotebookInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerNotebookInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerNotebookInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerNotebookInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerNotebookInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#instance_type-1">SagemakerNotebookInstance#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: SagemakerNotebookInstanceState<Missing, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<Present, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : SagemakerNotebookInstanceState<Present, 'Name, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#name-1">SagemakerNotebookInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerNotebookInstanceState<'InstanceType, Missing, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SagemakerNotebookInstanceState<'InstanceType, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#role_arn-1">SagemakerNotebookInstance#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, Missing>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerNotebookInstanceState<'InstanceType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#accelerator_types-1">SagemakerNotebookInstance#accelerator_types</a>.
        /// </summary>
        [<CustomOperation "accelerator_types">]
        member _.AcceleratorTypes(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: seq<string>) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.AcceleratorTypes <- (value |> Seq.toArray))
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#additional_code_repositories-1">SagemakerNotebookInstance#additional_code_repositories</a>.
        /// </summary>
        [<CustomOperation "additional_code_repositories">]
        member _.AdditionalCodeRepositories(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: seq<string>) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.AdditionalCodeRepositories <- (value |> Seq.toArray))
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#default_code_repository-1">SagemakerNotebookInstance#default_code_repository</a>.
        /// </summary>
        [<CustomOperation "default_code_repository">]
        member _.DefaultCodeRepository(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DefaultCodeRepository <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#direct_internet_access-1">SagemakerNotebookInstance#direct_internet_access</a>.
        /// </summary>
        [<CustomOperation "direct_internet_access">]
        member _.DirectInternetAccess(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DirectInternetAccess <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#id-1">SagemakerNotebookInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// instance_metadata_service_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#instance_metadata_service_configuration-1">SagemakerNotebookInstance#instance_metadata_service_configuration</a>
        /// </summary>
        [<CustomOperation "instance_metadata_service_configuration">]
        member _.InstanceMetadataServiceConfiguration(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: aws.SagemakerNotebookInstance.SagemakerNotebookInstanceInstanceMetadataServiceConfiguration) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.InstanceMetadataServiceConfiguration <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#kms_key_id-1">SagemakerNotebookInstance#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#lifecycle_config_name-1">SagemakerNotebookInstance#lifecycle_config_name</a>.
        /// </summary>
        [<CustomOperation "lifecycle_config_name">]
        member _.LifecycleConfigName(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.LifecycleConfigName <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#platform_identifier-1">SagemakerNotebookInstance#platform_identifier</a>.
        /// </summary>
        [<CustomOperation "platform_identifier">]
        member _.PlatformIdentifier(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.PlatformIdentifier <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#root_access-1">SagemakerNotebookInstance#root_access</a>.
        /// </summary>
        [<CustomOperation "root_access">]
        member _.RootAccess(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.RootAccess <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#security_groups-1">SagemakerNotebookInstance#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: seq<string>) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#subnet_id-1">SagemakerNotebookInstance#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: string) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#tags-1">SagemakerNotebookInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: seq<string * string>) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#tags_all-1">SagemakerNotebookInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: seq<string * string>) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#volume_size-1">SagemakerNotebookInstance#volume_size</a>.
        /// </summary>
        [<CustomOperation "volume_size">]
        member _.VolumeSize(state: SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>, value: double) : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.VolumeSize <- value)
            state : SagemakerNotebookInstanceState<'InstanceType, 'Name, 'RoleArn>

        member _.Run(state: SagemakerNotebookInstanceState<Present, Present, Present>) : aws.SagemakerNotebookInstance.SagemakerNotebookInstance =
            let config = aws.SagemakerNotebookInstance.SagemakerNotebookInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerNotebookInstance.SagemakerNotebookInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerNotebookInstance: missing required arguments. Must call: instance_type, name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerNotebookInstanceState<_, _, _>) : aws.SagemakerNotebookInstance.SagemakerNotebookInstance =
            Unchecked.defaultof<aws.SagemakerNotebookInstance.SagemakerNotebookInstance>
