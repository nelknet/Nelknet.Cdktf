namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId> = { assignments: ResizeArray<aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option_resource_association">aws_servicecatalog_tag_option_resource_association</a>.
    /// </summary>
    type ServicecatalogTagOptionResourceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogTagOptionResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogTagOptionResourceAssociationState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogTagOptionResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogTagOptionResourceAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option_resource_association#resource_id-1">ServicecatalogTagOptionResourceAssociation#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ServicecatalogTagOptionResourceAssociationState<Missing, 'TagOptionId>, value: string) : ServicecatalogTagOptionResourceAssociationState<Present, 'TagOptionId> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ServicecatalogTagOptionResourceAssociationState<Present, 'TagOptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option_resource_association#tag_option_id-1">ServicecatalogTagOptionResourceAssociation#tag_option_id</a>.
        /// </summary>
        [<CustomOperation "tag_option_id">]
        member _.TagOptionId(state: ServicecatalogTagOptionResourceAssociationState<'ResourceId, Missing>, value: string) : ServicecatalogTagOptionResourceAssociationState<'ResourceId, Present> =
            state.assignments.Add(fun config -> config.TagOptionId <- value)
            ({ assignments = state.assignments } : ServicecatalogTagOptionResourceAssociationState<'ResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option_resource_association#id-1">ServicecatalogTagOptionResourceAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId>, value: string) : ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_tag_option_resource_association#timeouts-1">ServicecatalogTagOptionResourceAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId>, value: aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociationTimeouts) : ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogTagOptionResourceAssociationState<'ResourceId, 'TagOptionId>

        member _.Run(state: ServicecatalogTagOptionResourceAssociationState<Present, Present>) : aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociation =
            let config = aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogTagOptionResourceAssociation: missing required arguments. Must call: resource_id, tag_option_id.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogTagOptionResourceAssociationState<_, _>) : aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociation =
            Unchecked.defaultof<aws.ServicecatalogTagOptionResourceAssociation.ServicecatalogTagOptionResourceAssociation>
