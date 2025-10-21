namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogProvisionedProductState<'Name> = { assignments: ResizeArray<aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product">aws_servicecatalog_provisioned_product</a>.
    /// </summary>
    type ServicecatalogProvisionedProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogProvisionedProductState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProvisionedProductState<Missing>)

        member _.Zero(()) : ServicecatalogProvisionedProductState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProvisionedProductState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#name-1">ServicecatalogProvisionedProduct#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogProvisionedProductState<Missing>, value: string) : ServicecatalogProvisionedProductState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogProvisionedProductState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#accept_language-1">ServicecatalogProvisionedProduct#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#id-1">ServicecatalogProvisionedProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#ignore_errors-1">ServicecatalogProvisionedProduct#ignore_errors</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_errors">]
        member _.IgnoreErrors(state: ServicecatalogProvisionedProductState<'Name>, value: bool) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.IgnoreErrors <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#ignore_errors-1">ServicecatalogProvisionedProduct#ignore_errors</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_errors">]
        member _.IgnoreErrors(state: ServicecatalogProvisionedProductState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.IgnoreErrors <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#notification_arns-1">ServicecatalogProvisionedProduct#notification_arns</a>.
        /// </summary>
        [<CustomOperation "notification_arns">]
        member _.NotificationArns(state: ServicecatalogProvisionedProductState<'Name>, value: seq<string>) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.NotificationArns <- (value |> Seq.toArray))
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#path_id-1">ServicecatalogProvisionedProduct#path_id</a>.
        /// </summary>
        [<CustomOperation "path_id">]
        member _.PathId(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.PathId <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#path_name-1">ServicecatalogProvisionedProduct#path_name</a>.
        /// </summary>
        [<CustomOperation "path_name">]
        member _.PathName(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.PathName <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#product_id-1">ServicecatalogProvisionedProduct#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#product_name-1">ServicecatalogProvisionedProduct#product_name</a>.
        /// </summary>
        [<CustomOperation "product_name">]
        member _.ProductName(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.ProductName <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#provisioning_artifact_id-1">ServicecatalogProvisionedProduct#provisioning_artifact_id</a>.
        /// </summary>
        [<CustomOperation "provisioning_artifact_id">]
        member _.ProvisioningArtifactId(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.ProvisioningArtifactId <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#provisioning_artifact_name-1">ServicecatalogProvisionedProduct#provisioning_artifact_name</a>.
        /// </summary>
        [<CustomOperation "provisioning_artifact_name">]
        member _.ProvisioningArtifactName(state: ServicecatalogProvisionedProductState<'Name>, value: string) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.ProvisioningArtifactName <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// provisioning_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#provisioning_parameters-1">ServicecatalogProvisionedProduct#provisioning_parameters</a> Accepts: aws.IResolvable | aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProductProvisioningParameters[]
        /// </summary>
        [<CustomOperation "provisioning_parameters">]
        member _.ProvisioningParameters(state: ServicecatalogProvisionedProductState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.ProvisioningParameters <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#retain_physical_resources-1">ServicecatalogProvisionedProduct#retain_physical_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_physical_resources">]
        member _.RetainPhysicalResources(state: ServicecatalogProvisionedProductState<'Name>, value: bool) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.RetainPhysicalResources <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#retain_physical_resources-1">ServicecatalogProvisionedProduct#retain_physical_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_physical_resources">]
        member _.RetainPhysicalResources(state: ServicecatalogProvisionedProductState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.RetainPhysicalResources <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// stack_set_provisioning_preferences block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#stack_set_provisioning_preferences-1">ServicecatalogProvisionedProduct#stack_set_provisioning_preferences</a>
        /// </summary>
        [<CustomOperation "stack_set_provisioning_preferences">]
        member _.StackSetProvisioningPreferences(state: ServicecatalogProvisionedProductState<'Name>, value: aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProductStackSetProvisioningPreferences) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.StackSetProvisioningPreferences <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#tags-1">ServicecatalogProvisionedProduct#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicecatalogProvisionedProductState<'Name>, value: seq<string * string>) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#tags_all-1">ServicecatalogProvisionedProduct#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServicecatalogProvisionedProductState<'Name>, value: seq<string * string>) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServicecatalogProvisionedProductState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioned_product#timeouts-1">ServicecatalogProvisionedProduct#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogProvisionedProductState<'Name>, value: aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProductTimeouts) : ServicecatalogProvisionedProductState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogProvisionedProductState<'Name>

        member _.Run(state: ServicecatalogProvisionedProductState<Present>) : aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProduct =
            let config = aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProductConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogProvisionedProduct: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogProvisionedProductState<_>) : aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProduct =
            Unchecked.defaultof<aws.ServicecatalogProvisionedProduct.ServicecatalogProvisionedProduct>
