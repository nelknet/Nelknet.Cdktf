namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> = { assignments: ResizeArray<aws.OpsworksStack.OpsworksStackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack">aws_opsworks_stack</a>.
    /// </summary>
    type OpsworksStackBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksStackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksStackState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OpsworksStackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksStackState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_instance_profile_arn-1">OpsworksStack#default_instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "default_instance_profile_arn">]
        member _.DefaultInstanceProfileArn(state: OpsworksStackState<Missing, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<Present, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultInstanceProfileArn <- value)
            ({ assignments = state.assignments } : OpsworksStackState<Present, 'Name, 'Region, 'ServiceRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#name-1">OpsworksStack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksStackState<'DefaultInstanceProfileArn, Missing, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, Present, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpsworksStackState<'DefaultInstanceProfileArn, Present, 'Region, 'ServiceRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#region-1">OpsworksStack#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, Missing, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, Present, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Region <- value)
            ({ assignments = state.assignments } : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, Present, 'ServiceRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#service_role_arn-1">OpsworksStack#service_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_role_arn">]
        member _.ServiceRoleArn(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, Missing>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, Present> =
            state.assignments.Add(fun config -> config.ServiceRoleArn <- value)
            ({ assignments = state.assignments } : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#agent_version-1">OpsworksStack#agent_version</a>.
        /// </summary>
        [<CustomOperation "agent_version">]
        member _.AgentVersion(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.AgentVersion <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#berkshelf_version-1">OpsworksStack#berkshelf_version</a>.
        /// </summary>
        [<CustomOperation "berkshelf_version">]
        member _.BerkshelfVersion(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.BerkshelfVersion <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#color-1">OpsworksStack#color</a>.
        /// </summary>
        [<CustomOperation "color">]
        member _.Color(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Color <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#configuration_manager_name-1">OpsworksStack#configuration_manager_name</a>.
        /// </summary>
        [<CustomOperation "configuration_manager_name">]
        member _.ConfigurationManagerName(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.ConfigurationManagerName <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#configuration_manager_version-1">OpsworksStack#configuration_manager_version</a>.
        /// </summary>
        [<CustomOperation "configuration_manager_version">]
        member _.ConfigurationManagerVersion(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.ConfigurationManagerVersion <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// custom_cookbooks_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#custom_cookbooks_source-1">OpsworksStack#custom_cookbooks_source</a>
        /// </summary>
        [<CustomOperation "custom_cookbooks_source">]
        member _.CustomCookbooksSource(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: aws.OpsworksStack.OpsworksStackCustomCookbooksSource) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.CustomCookbooksSource <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#custom_json-1">OpsworksStack#custom_json</a>.
        /// </summary>
        [<CustomOperation "custom_json">]
        member _.CustomJson(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.CustomJson <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_availability_zone-1">OpsworksStack#default_availability_zone</a>.
        /// </summary>
        [<CustomOperation "default_availability_zone">]
        member _.DefaultAvailabilityZone(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultAvailabilityZone <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_os-1">OpsworksStack#default_os</a>.
        /// </summary>
        [<CustomOperation "default_os">]
        member _.DefaultOs(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultOs <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_root_device_type-1">OpsworksStack#default_root_device_type</a>.
        /// </summary>
        [<CustomOperation "default_root_device_type">]
        member _.DefaultRootDeviceType(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultRootDeviceType <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_ssh_key_name-1">OpsworksStack#default_ssh_key_name</a>.
        /// </summary>
        [<CustomOperation "default_ssh_key_name">]
        member _.DefaultSshKeyName(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultSshKeyName <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#default_subnet_id-1">OpsworksStack#default_subnet_id</a>.
        /// </summary>
        [<CustomOperation "default_subnet_id">]
        member _.DefaultSubnetId(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.DefaultSubnetId <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#hostname_theme-1">OpsworksStack#hostname_theme</a>.
        /// </summary>
        [<CustomOperation "hostname_theme">]
        member _.HostnameTheme(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.HostnameTheme <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#id-1">OpsworksStack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#manage_berkshelf-1">OpsworksStack#manage_berkshelf</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_berkshelf">]
        member _.ManageBerkshelf(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: bool) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.ManageBerkshelf <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#manage_berkshelf-1">OpsworksStack#manage_berkshelf</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_berkshelf">]
        member _.ManageBerkshelf(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.ManageBerkshelf <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#tags-1">OpsworksStack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: seq<string * string>) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#tags_all-1">OpsworksStack#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: seq<string * string>) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#timeouts-1">OpsworksStack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: aws.OpsworksStack.OpsworksStackTimeouts) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#use_custom_cookbooks-1">OpsworksStack#use_custom_cookbooks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_custom_cookbooks">]
        member _.UseCustomCookbooks(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: bool) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.UseCustomCookbooks <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#use_custom_cookbooks-1">OpsworksStack#use_custom_cookbooks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_custom_cookbooks">]
        member _.UseCustomCookbooks(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.UseCustomCookbooks <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#use_opsworks_security_groups-1">OpsworksStack#use_opsworks_security_groups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_opsworks_security_groups">]
        member _.UseOpsworksSecurityGroups(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: bool) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.UseOpsworksSecurityGroups <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#use_opsworks_security_groups-1">OpsworksStack#use_opsworks_security_groups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_opsworks_security_groups">]
        member _.UseOpsworksSecurityGroups(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.UseOpsworksSecurityGroups <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_stack#vpc_id-1">OpsworksStack#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>, value: string) : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : OpsworksStackState<'DefaultInstanceProfileArn, 'Name, 'Region, 'ServiceRoleArn>

        member _.Run(state: OpsworksStackState<Present, Present, Present, Present>) : aws.OpsworksStack.OpsworksStack =
            let config = aws.OpsworksStack.OpsworksStackConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksStack.OpsworksStack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksStack: missing required arguments. Must call: default_instance_profile_arn, name, region, service_role_arn.", 9999, IsError = true)>]
        member _.Run(_: OpsworksStackState<_, _, _, _>) : aws.OpsworksStack.OpsworksStack =
            Unchecked.defaultof<aws.OpsworksStack.OpsworksStack>
