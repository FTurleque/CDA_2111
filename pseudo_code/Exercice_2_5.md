***Doc ABC Algo 05 - Algorithme Exercices - 1.0.1 MD***

**VARIABLE**
************
    int : user_number, N, total_point_user, total_point_N

**CODE**
**********
    total_point_user <-- 0
    total_point_N <-- 0

    Repeat
        N <-- RANDOM(0,2)
        write "Choisir un chiffre entre 0 et 2 :"
        read user_number
        If user_number = N + 2 OU user_number = N - 2 then
            If user_number > N then
                total_point_user <-- total_point_user + 1
            Else
                total_point_N <-- total_point_N + 1
            EndIf
        EndIf
        
        If user_number = N + 1 OU user_number = N - 1 then
            If user_number > N then
                total_point_N <-- total_point_N + 1
            Else
                total_point_user <-- total_point_user + 1
            EndIf
        EndIf

        If user_number = N then
            write "Egalitée, personne ne marque de point"
        EndIf
    Until

    If total_point_N = 10 then
        write "Vous avez perdu !"
    Else
        write "Vous avez gagné !"
    EndIf