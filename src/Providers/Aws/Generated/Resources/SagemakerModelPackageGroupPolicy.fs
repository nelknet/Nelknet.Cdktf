namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, 'ResourcePolicy> = { assignments: ResizeArray<aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group_policy">aws_sagemaker_model_package_group_policy</a>.
    /// </summary>
    type SagemakerModelPackageGroupPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerModelPackageGroupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelPackageGroupPolicyState<Missing, Missing>)

        member _.Zero(()) : SagemakerModelPackageGroupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelPackageGroupPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group_policy#model_package_group_name-1">SagemakerModelPackageGroupPolicy#model_package_group_name</a>.
        /// </summary>
        [<CustomOperation "model_package_group_name">]
        member _.ModelPackageGroupName(state: SagemakerModelPackageGroupPolicyState<Missing, 'ResourcePolicy>, value: string) : SagemakerModelPackageGroupPolicyState<Present, 'ResourcePolicy> =
            state.assignments.Add(fun config -> config.ModelPackageGroupName <- value)
            ({ assignments = state.assignments } : SagemakerModelPackageGroupPolicyState<Present, 'ResourcePolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group_policy#resource_policy-1">SagemakerModelPackageGroupPolicy#resource_policy</a>.
        /// </summary>
        [<CustomOperation "resource_policy">]
        member _.ResourcePolicy(state: SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, Missing>, value: string) : SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, Present> =
            state.assignments.Add(fun config -> config.ResourcePolicy <- value)
            ({ assignments = state.assignments } : SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model_package_group_policy#id-1">SagemakerModelPackageGroupPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, 'ResourcePolicy>, value: string) : SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, 'ResourcePolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerModelPackageGroupPolicyState<'ModelPackageGroupName, 'ResourcePolicy>

        member _.Run(state: SagemakerModelPackageGroupPolicyState<Present, Present>) : aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicy =
            let config = aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerModelPackageGroupPolicy: missing required arguments. Must call: model_package_group_name, resource_policy.", 9999, IsError = true)>]
        member _.Run(_: SagemakerModelPackageGroupPolicyState<_, _>) : aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicy =
            Unchecked.defaultof<aws.SagemakerModelPackageGroupPolicy.SagemakerModelPackageGroupPolicy>
