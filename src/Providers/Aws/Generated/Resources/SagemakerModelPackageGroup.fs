namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerModelPackageGroupState<'ModelPackageGroupName> = { assignments: ResizeArray<aws.SagemakerModelPackageGroup.SagemakerModelPackageGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group">aws_sagemaker_model_package_group</a>.
    /// </summary>
    type SagemakerModelPackageGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerModelPackageGroupState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelPackageGroupState<Missing>)

        member _.Zero(()) : SagemakerModelPackageGroupState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelPackageGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group#model_package_group_name-1">SagemakerModelPackageGroup#model_package_group_name</a>.
        /// </summary>
        [<CustomOperation "model_package_group_name">]
        member _.ModelPackageGroupName(state: SagemakerModelPackageGroupState<Missing>, value: string) : SagemakerModelPackageGroupState<Present> =
            state.assignments.Add(fun config -> config.ModelPackageGroupName <- value)
            ({ assignments = state.assignments } : SagemakerModelPackageGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group#id-1">SagemakerModelPackageGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerModelPackageGroupState<'ModelPackageGroupName>, value: string) : SagemakerModelPackageGroupState<'ModelPackageGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerModelPackageGroupState<'ModelPackageGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group#model_package_group_description-1">SagemakerModelPackageGroup#model_package_group_description</a>.
        /// </summary>
        [<CustomOperation "model_package_group_description">]
        member _.ModelPackageGroupDescription(state: SagemakerModelPackageGroupState<'ModelPackageGroupName>, value: string) : SagemakerModelPackageGroupState<'ModelPackageGroupName> =
            state.assignments.Add(fun config -> config.ModelPackageGroupDescription <- value)
            state : SagemakerModelPackageGroupState<'ModelPackageGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group#tags-1">SagemakerModelPackageGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerModelPackageGroupState<'ModelPackageGroupName>, value: seq<string * string>) : SagemakerModelPackageGroupState<'ModelPackageGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerModelPackageGroupState<'ModelPackageGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group#tags_all-1">SagemakerModelPackageGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerModelPackageGroupState<'ModelPackageGroupName>, value: seq<string * string>) : SagemakerModelPackageGroupState<'ModelPackageGroupName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerModelPackageGroupState<'ModelPackageGroupName>

        member _.Run(state: SagemakerModelPackageGroupState<Present>) : aws.SagemakerModelPackageGroup.SagemakerModelPackageGroup =
            let config = aws.SagemakerModelPackageGroup.SagemakerModelPackageGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerModelPackageGroup.SagemakerModelPackageGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerModelPackageGroup: missing required arguments. Must call: model_package_group_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerModelPackageGroupState<_>) : aws.SagemakerModelPackageGroup.SagemakerModelPackageGroup =
            Unchecked.defaultof<aws.SagemakerModelPackageGroup.SagemakerModelPackageGroup>
