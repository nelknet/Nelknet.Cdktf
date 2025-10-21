namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogappregistryAttributeGroupAssociationsState = { assignments: ResizeArray<aws.DataAwsServicecatalogappregistryAttributeGroupAssociations.DataAwsServicecatalogappregistryAttributeGroupAssociationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group_associations">aws_servicecatalogappregistry_attribute_group_associations</a>.
    /// </summary>
    type DataAwsServicecatalogappregistryAttributeGroupAssociationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogappregistryAttributeGroupAssociationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsServicecatalogappregistryAttributeGroupAssociationsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group_associations#id-1">DataAwsServicecatalogappregistryAttributeGroupAssociations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogappregistryAttributeGroupAssociationsState, value: string) : DataAwsServicecatalogappregistryAttributeGroupAssociationsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicecatalogappregistryAttributeGroupAssociationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group_associations#name-1">DataAwsServicecatalogappregistryAttributeGroupAssociations#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsServicecatalogappregistryAttributeGroupAssociationsState, value: string) : DataAwsServicecatalogappregistryAttributeGroupAssociationsState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsServicecatalogappregistryAttributeGroupAssociationsState

        member _.Run(state: DataAwsServicecatalogappregistryAttributeGroupAssociationsState) : aws.DataAwsServicecatalogappregistryAttributeGroupAssociations.DataAwsServicecatalogappregistryAttributeGroupAssociations =
            let config = aws.DataAwsServicecatalogappregistryAttributeGroupAssociations.DataAwsServicecatalogappregistryAttributeGroupAssociationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogappregistryAttributeGroupAssociations.DataAwsServicecatalogappregistryAttributeGroupAssociations(StackContext.get (), logicalId, config)
