namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudtrailEventDataStoreState<'Name> = { assignments: ResizeArray<aws.CloudtrailEventDataStore.CloudtrailEventDataStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store">aws_cloudtrail_event_data_store</a>.
    /// </summary>
    type CloudtrailEventDataStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudtrailEventDataStoreState<Missing> =
            ({ assignments = ResizeArray() } : CloudtrailEventDataStoreState<Missing>)

        member _.Zero(()) : CloudtrailEventDataStoreState<Missing> =
            ({ assignments = ResizeArray() } : CloudtrailEventDataStoreState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#name-1">CloudtrailEventDataStore#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudtrailEventDataStoreState<Missing>, value: string) : CloudtrailEventDataStoreState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudtrailEventDataStoreState<Present>)

        /// <summary>
        /// advanced_event_selector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#advanced_event_selector-1">CloudtrailEventDataStore#advanced_event_selector</a> Accepts: aws.IResolvable | aws.CloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelector[]
        /// </summary>
        [<CustomOperation "advanced_event_selector">]
        member _.AdvancedEventSelector(state: CloudtrailEventDataStoreState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.AdvancedEventSelector <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#billing_mode-1">CloudtrailEventDataStore#billing_mode</a>.
        /// </summary>
        [<CustomOperation "billing_mode">]
        member _.BillingMode(state: CloudtrailEventDataStoreState<'Name>, value: string) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.BillingMode <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#id-1">CloudtrailEventDataStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudtrailEventDataStoreState<'Name>, value: string) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#kms_key_id-1">CloudtrailEventDataStore#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: CloudtrailEventDataStoreState<'Name>, value: string) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#multi_region_enabled-1">CloudtrailEventDataStore#multi_region_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region_enabled">]
        member _.MultiRegionEnabled(state: CloudtrailEventDataStoreState<'Name>, value: bool) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.MultiRegionEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#multi_region_enabled-1">CloudtrailEventDataStore#multi_region_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_region_enabled">]
        member _.MultiRegionEnabled(state: CloudtrailEventDataStoreState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.MultiRegionEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#organization_enabled-1">CloudtrailEventDataStore#organization_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "organization_enabled">]
        member _.OrganizationEnabled(state: CloudtrailEventDataStoreState<'Name>, value: bool) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.OrganizationEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#organization_enabled-1">CloudtrailEventDataStore#organization_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "organization_enabled">]
        member _.OrganizationEnabled(state: CloudtrailEventDataStoreState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.OrganizationEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#retention_period-1">CloudtrailEventDataStore#retention_period</a>.
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: CloudtrailEventDataStoreState<'Name>, value: double) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#suspend-1">CloudtrailEventDataStore#suspend</a>.
        /// </summary>
        [<CustomOperation "suspend">]
        member _.Suspend(state: CloudtrailEventDataStoreState<'Name>, value: string) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.Suspend <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#tags-1">CloudtrailEventDataStore#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudtrailEventDataStoreState<'Name>, value: seq<string * string>) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#tags_all-1">CloudtrailEventDataStore#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudtrailEventDataStoreState<'Name>, value: seq<string * string>) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#termination_protection_enabled-1">CloudtrailEventDataStore#termination_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection_enabled">]
        member _.TerminationProtectionEnabled(state: CloudtrailEventDataStoreState<'Name>, value: bool) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.TerminationProtectionEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#termination_protection_enabled-1">CloudtrailEventDataStore#termination_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection_enabled">]
        member _.TerminationProtectionEnabled(state: CloudtrailEventDataStoreState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.TerminationProtectionEnabled <- value)
            state : CloudtrailEventDataStoreState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#timeouts-1">CloudtrailEventDataStore#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudtrailEventDataStoreState<'Name>, value: aws.CloudtrailEventDataStore.CloudtrailEventDataStoreTimeouts) : CloudtrailEventDataStoreState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudtrailEventDataStoreState<'Name>

        member _.Run(state: CloudtrailEventDataStoreState<Present>) : aws.CloudtrailEventDataStore.CloudtrailEventDataStore =
            let config = aws.CloudtrailEventDataStore.CloudtrailEventDataStoreConfig()
            for setter in state.assignments do
                setter config
            aws.CloudtrailEventDataStore.CloudtrailEventDataStore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudtrailEventDataStore: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudtrailEventDataStoreState<_>) : aws.CloudtrailEventDataStore.CloudtrailEventDataStore =
            Unchecked.defaultof<aws.CloudtrailEventDataStore.CloudtrailEventDataStore>
