namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails> = { assignments: ResizeArray<aws.SagemakerProject.SagemakerProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project">aws_sagemaker_project</a>.
    /// </summary>
    type SagemakerProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerProjectState<Missing, Missing>)

        member _.Zero(()) : SagemakerProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerProjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#project_name-1">SagemakerProject#project_name</a>.
        /// </summary>
        [<CustomOperation "project_name">]
        member _.ProjectName(state: SagemakerProjectState<Missing, 'ServiceCatalogProvisioningDetails>, value: string) : SagemakerProjectState<Present, 'ServiceCatalogProvisioningDetails> =
            state.assignments.Add(fun config -> config.ProjectName <- value)
            ({ assignments = state.assignments } : SagemakerProjectState<Present, 'ServiceCatalogProvisioningDetails>)

        /// <summary>
        /// service_catalog_provisioning_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#service_catalog_provisioning_details-1">SagemakerProject#service_catalog_provisioning_details</a>
        /// </summary>
        [<CustomOperation "service_catalog_provisioning_details">]
        member _.ServiceCatalogProvisioningDetails(state: SagemakerProjectState<'ProjectName, Missing>, value: aws.SagemakerProject.SagemakerProjectServiceCatalogProvisioningDetails) : SagemakerProjectState<'ProjectName, Present> =
            state.assignments.Add(fun config -> config.ServiceCatalogProvisioningDetails <- value)
            ({ assignments = state.assignments } : SagemakerProjectState<'ProjectName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#id-1">SagemakerProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>, value: string) : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#project_description-1">SagemakerProject#project_description</a>.
        /// </summary>
        [<CustomOperation "project_description">]
        member _.ProjectDescription(state: SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>, value: string) : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails> =
            state.assignments.Add(fun config -> config.ProjectDescription <- value)
            state : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#tags-1">SagemakerProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>, value: seq<string * string>) : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_project#tags_all-1">SagemakerProject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>, value: seq<string * string>) : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerProjectState<'ProjectName, 'ServiceCatalogProvisioningDetails>

        member _.Run(state: SagemakerProjectState<Present, Present>) : aws.SagemakerProject.SagemakerProject =
            let config = aws.SagemakerProject.SagemakerProjectConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerProject.SagemakerProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerProject: missing required arguments. Must call: project_name, service_catalog_provisioning_details.", 9999, IsError = true)>]
        member _.Run(_: SagemakerProjectState<_, _>) : aws.SagemakerProject.SagemakerProject =
            Unchecked.defaultof<aws.SagemakerProject.SagemakerProject>
