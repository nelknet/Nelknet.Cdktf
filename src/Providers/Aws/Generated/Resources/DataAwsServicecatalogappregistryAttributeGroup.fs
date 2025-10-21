namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogappregistryAttributeGroupState = { assignments: ResizeArray<aws.DataAwsServicecatalogappregistryAttributeGroup.DataAwsServicecatalogappregistryAttributeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group">aws_servicecatalogappregistry_attribute_group</a>.
    /// </summary>
    type DataAwsServicecatalogappregistryAttributeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogappregistryAttributeGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsServicecatalogappregistryAttributeGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group#arn-1">DataAwsServicecatalogappregistryAttributeGroup#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsServicecatalogappregistryAttributeGroupState, value: string) : DataAwsServicecatalogappregistryAttributeGroupState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsServicecatalogappregistryAttributeGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group#id-1">DataAwsServicecatalogappregistryAttributeGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogappregistryAttributeGroupState, value: string) : DataAwsServicecatalogappregistryAttributeGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicecatalogappregistryAttributeGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_attribute_group#name-1">DataAwsServicecatalogappregistryAttributeGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsServicecatalogappregistryAttributeGroupState, value: string) : DataAwsServicecatalogappregistryAttributeGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsServicecatalogappregistryAttributeGroupState

        member _.Run(state: DataAwsServicecatalogappregistryAttributeGroupState) : aws.DataAwsServicecatalogappregistryAttributeGroup.DataAwsServicecatalogappregistryAttributeGroup =
            let config = aws.DataAwsServicecatalogappregistryAttributeGroup.DataAwsServicecatalogappregistryAttributeGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogappregistryAttributeGroup.DataAwsServicecatalogappregistryAttributeGroup(StackContext.get (), logicalId, config)
