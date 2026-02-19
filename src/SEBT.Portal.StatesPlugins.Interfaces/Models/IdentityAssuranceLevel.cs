namespace SEBT.Portal.StatesPlugins.Interfaces.Models;

/// <summary>
/// Identity Assurance Level (IAL) the user has achieved through ID proofing.
/// Aligns with NIST 800-63 and portal user state. Passed to plugins so they can
/// apply backend policy (e.g. whether to return address) from actual proofing status.
/// </summary>
public enum IdentityAssuranceLevel
{
    /// <summary>No IAL achieved; user has not completed ID proofing.</summary>
    None = 0,

    /// <summary>IAL1 — basic identity verification completed.</summary>
    IAL1 = 1,

    /// <summary>IAL1+ — enhanced verification completed.</summary>
    IAL1plus = 2,

    /// <summary>IAL2 — reserved for future use.</summary>
    IAL2 = 3
}
