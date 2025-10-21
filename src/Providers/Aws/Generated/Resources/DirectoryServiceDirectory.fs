namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceDirectoryState<'Name, 'Password> = { assignments: ResizeArray<aws.DirectoryServiceDirectory.DirectoryServiceDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory">aws_directory_service_directory</a>.
    /// </summary>
    type DirectoryServiceDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceDirectoryState<Missing, Missing>)

        member _.Zero(()) : DirectoryServiceDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceDirectoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#name-1">DirectoryServiceDirectory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DirectoryServiceDirectoryState<Missing, 'Password>, value: string) : DirectoryServiceDirectoryState<Present, 'Password> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DirectoryServiceDirectoryState<Present, 'Password>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#password-1">DirectoryServiceDirectory#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DirectoryServiceDirectoryState<'Name, Missing>, value: string) : DirectoryServiceDirectoryState<'Name, Present> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : DirectoryServiceDirectoryState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#alias-1">DirectoryServiceDirectory#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// connect_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#connect_settings-1">DirectoryServiceDirectory#connect_settings</a>
        /// </summary>
        [<CustomOperation "connect_settings">]
        member _.ConnectSettings(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: aws.DirectoryServiceDirectory.DirectoryServiceDirectoryConnectSettings) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.ConnectSettings <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#description-1">DirectoryServiceDirectory#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#desired_number_of_domain_controllers-1">DirectoryServiceDirectory#desired_number_of_domain_controllers</a>.
        /// </summary>
        [<CustomOperation "desired_number_of_domain_controllers">]
        member _.DesiredNumberOfDomainControllers(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: double) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.DesiredNumberOfDomainControllers <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#edition-1">DirectoryServiceDirectory#edition</a>.
        /// </summary>
        [<CustomOperation "edition">]
        member _.Edition(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Edition <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#enable_sso-1">DirectoryServiceDirectory#enable_sso</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sso">]
        member _.EnableSso(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: bool) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.EnableSso <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#enable_sso-1">DirectoryServiceDirectory#enable_sso</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sso">]
        member _.EnableSso(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: HashiCorp.Cdktf.IResolvable) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.EnableSso <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#id-1">DirectoryServiceDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#short_name-1">DirectoryServiceDirectory#short_name</a>.
        /// </summary>
        [<CustomOperation "short_name">]
        member _.ShortName(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.ShortName <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#size-1">DirectoryServiceDirectory#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Size <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#tags-1">DirectoryServiceDirectory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: seq<string * string>) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#tags_all-1">DirectoryServiceDirectory#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: seq<string * string>) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#timeouts-1">DirectoryServiceDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: aws.DirectoryServiceDirectory.DirectoryServiceDirectoryTimeouts) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#type-1">DirectoryServiceDirectory#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: string) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        /// <summary>
        /// vpc_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_directory#vpc_settings-1">DirectoryServiceDirectory#vpc_settings</a>
        /// </summary>
        [<CustomOperation "vpc_settings">]
        member _.VpcSettings(state: DirectoryServiceDirectoryState<'Name, 'Password>, value: aws.DirectoryServiceDirectory.DirectoryServiceDirectoryVpcSettings) : DirectoryServiceDirectoryState<'Name, 'Password> =
            state.assignments.Add(fun config -> config.VpcSettings <- value)
            state : DirectoryServiceDirectoryState<'Name, 'Password>

        member _.Run(state: DirectoryServiceDirectoryState<Present, Present>) : aws.DirectoryServiceDirectory.DirectoryServiceDirectory =
            let config = aws.DirectoryServiceDirectory.DirectoryServiceDirectoryConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceDirectory.DirectoryServiceDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceDirectory: missing required arguments. Must call: name, password.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceDirectoryState<_, _>) : aws.DirectoryServiceDirectory.DirectoryServiceDirectory =
            Unchecked.defaultof<aws.DirectoryServiceDirectory.DirectoryServiceDirectory>
