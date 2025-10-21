namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmInstanceProfileState<'Name> = { assignments: ResizeArray<aws.DevicefarmInstanceProfile.DevicefarmInstanceProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile">aws_devicefarm_instance_profile</a>.
    /// </summary>
    type DevicefarmInstanceProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmInstanceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmInstanceProfileState<Missing>)

        member _.Zero(()) : DevicefarmInstanceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmInstanceProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#name-1">DevicefarmInstanceProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmInstanceProfileState<Missing>, value: string) : DevicefarmInstanceProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmInstanceProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#description-1">DevicefarmInstanceProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevicefarmInstanceProfileState<'Name>, value: string) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#exclude_app_packages_from_cleanup-1">DevicefarmInstanceProfile#exclude_app_packages_from_cleanup</a>.
        /// </summary>
        [<CustomOperation "exclude_app_packages_from_cleanup">]
        member _.ExcludeAppPackagesFromCleanup(state: DevicefarmInstanceProfileState<'Name>, value: seq<string>) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.ExcludeAppPackagesFromCleanup <- (value |> Seq.toArray))
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#id-1">DevicefarmInstanceProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmInstanceProfileState<'Name>, value: string) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#package_cleanup-1">DevicefarmInstanceProfile#package_cleanup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "package_cleanup">]
        member _.PackageCleanup(state: DevicefarmInstanceProfileState<'Name>, value: bool) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.PackageCleanup <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#package_cleanup-1">DevicefarmInstanceProfile#package_cleanup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "package_cleanup">]
        member _.PackageCleanup(state: DevicefarmInstanceProfileState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.PackageCleanup <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#reboot_after_use-1">DevicefarmInstanceProfile#reboot_after_use</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reboot_after_use">]
        member _.RebootAfterUse(state: DevicefarmInstanceProfileState<'Name>, value: bool) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.RebootAfterUse <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#reboot_after_use-1">DevicefarmInstanceProfile#reboot_after_use</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reboot_after_use">]
        member _.RebootAfterUse(state: DevicefarmInstanceProfileState<'Name>, value: HashiCorp.Cdktf.IResolvable) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.RebootAfterUse <- value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#tags-1">DevicefarmInstanceProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevicefarmInstanceProfileState<'Name>, value: seq<string * string>) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevicefarmInstanceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_instance_profile#tags_all-1">DevicefarmInstanceProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DevicefarmInstanceProfileState<'Name>, value: seq<string * string>) : DevicefarmInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DevicefarmInstanceProfileState<'Name>

        member _.Run(state: DevicefarmInstanceProfileState<Present>) : aws.DevicefarmInstanceProfile.DevicefarmInstanceProfile =
            let config = aws.DevicefarmInstanceProfile.DevicefarmInstanceProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmInstanceProfile.DevicefarmInstanceProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmInstanceProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmInstanceProfileState<_>) : aws.DevicefarmInstanceProfile.DevicefarmInstanceProfile =
            Unchecked.defaultof<aws.DevicefarmInstanceProfile.DevicefarmInstanceProfile>
