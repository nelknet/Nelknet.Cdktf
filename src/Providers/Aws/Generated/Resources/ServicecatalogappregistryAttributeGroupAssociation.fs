namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogappregistryAttributeGroupAssociationState<'ApplicationId, 'AttributeGroupId> = { assignments: ResizeArray<aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group_association">aws_servicecatalogappregistry_attribute_group_association</a>.
    /// </summary>
    type ServicecatalogappregistryAttributeGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogappregistryAttributeGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryAttributeGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogappregistryAttributeGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryAttributeGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// ID of the application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group_association#application_id-1">ServicecatalogappregistryAttributeGroupAssociation#application_id</a>
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: ServicecatalogappregistryAttributeGroupAssociationState<Missing, 'AttributeGroupId>, value: string) : ServicecatalogappregistryAttributeGroupAssociationState<Present, 'AttributeGroupId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : ServicecatalogappregistryAttributeGroupAssociationState<Present, 'AttributeGroupId>)

        /// <summary>
        /// ID of the attribute group to associate with the application. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group_association#attribute_group_id-1">ServicecatalogappregistryAttributeGroupAssociation#attribute_group_id</a>
        /// </summary>
        [<CustomOperation "attribute_group_id">]
        member _.AttributeGroupId(state: ServicecatalogappregistryAttributeGroupAssociationState<'ApplicationId, Missing>, value: string) : ServicecatalogappregistryAttributeGroupAssociationState<'ApplicationId, Present> =
            state.assignments.Add(fun config -> config.AttributeGroupId <- value)
            ({ assignments = state.assignments } : ServicecatalogappregistryAttributeGroupAssociationState<'ApplicationId, Present>)

        member _.Run(state: ServicecatalogappregistryAttributeGroupAssociationState<Present, Present>) : aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociation =
            let config = aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogappregistryAttributeGroupAssociation: missing required arguments. Must call: application_id, attribute_group_id.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogappregistryAttributeGroupAssociationState<_, _>) : aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociation =
            Unchecked.defaultof<aws.ServicecatalogappregistryAttributeGroupAssociation.ServicecatalogappregistryAttributeGroupAssociation>
