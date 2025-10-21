namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name> = { assignments: ResizeArray<aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group">aws_servicecatalogappregistry_attribute_group</a>.
    /// </summary>
    type ServicecatalogappregistryAttributeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogappregistryAttributeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryAttributeGroupState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogappregistryAttributeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryAttributeGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group#attributes-1">ServicecatalogappregistryAttributeGroup#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: ServicecatalogappregistryAttributeGroupState<Missing, 'Name>, value: string) : ServicecatalogappregistryAttributeGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Attributes <- value)
            ({ assignments = state.assignments } : ServicecatalogappregistryAttributeGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group#name-1">ServicecatalogappregistryAttributeGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogappregistryAttributeGroupState<'Attributes, Missing>, value: string) : ServicecatalogappregistryAttributeGroupState<'Attributes, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogappregistryAttributeGroupState<'Attributes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group#description-1">ServicecatalogappregistryAttributeGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name>, value: string) : ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_attribute_group#tags-1">ServicecatalogappregistryAttributeGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name>, value: seq<string * string>) : ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicecatalogappregistryAttributeGroupState<'Attributes, 'Name>

        member _.Run(state: ServicecatalogappregistryAttributeGroupState<Present, Present>) : aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroup =
            let config = aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogappregistryAttributeGroup: missing required arguments. Must call: attributes, name.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogappregistryAttributeGroupState<_, _>) : aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroup =
            Unchecked.defaultof<aws.ServicecatalogappregistryAttributeGroup.ServicecatalogappregistryAttributeGroup>
